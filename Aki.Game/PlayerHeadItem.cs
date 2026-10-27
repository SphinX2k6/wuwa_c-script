using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001952 RID: 6482
public class PlayerHeadItem : UiPanelBase
{
	// Token: 0x0600BD43 RID: 48451 RVA: 0x002ACB82 File Offset: 0x002AAD82
	[NullableContext(1)]
	public PlayerHeadItem(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600BD44 RID: 48452 RVA: 0x002ACB94 File Offset: 0x002AAD94
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BD45 RID: 48453 RVA: 0x002ACBDC File Offset: 0x002AADDC
	public void RefreshByPlayerId(int playerId, bool useCard = false)
	{
		this.RefreshPlayerTexture(playerId, useCard);
	}

	// Token: 0x0600BD46 RID: 48454 RVA: 0x002ACBE8 File Offset: 0x002AADE8
	private void RefreshPlayerTexture(int playerId, bool useCard = false)
	{
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		UUITexture texture = base.GetTexture(0);
		int? id = instance.GetId();
		if (id.GetValueOrDefault() == playerId & id != null)
		{
			if (useCard)
			{
				int headIconId = PlayerInfoModel.Instance.GetHeadIconId();
				this.RefreshByRoleIdUseCard(headIconId);
				return;
			}
			string playerHeadIconBig = PlayerInfoModel.Instance.GetPlayerHeadIconBig();
			if (!StringUtils.IsEmpty(playerHeadIconBig))
			{
				base.SetTextureByPath(playerHeadIconBig, texture, null, null);
			}
			return;
		}
		else
		{
			FriendData friendById = FriendModel.Instance.GetFriendById(playerId);
			if (friendById == null)
			{
				return;
			}
			int playerHeadPhoto = friendById.PlayerHeadPhoto;
			if (useCard)
			{
				this.RefreshByRoleIdUseCard(playerHeadPhoto);
				return;
			}
			this.RefreshByHeadPhotoId(playerHeadPhoto);
			return;
		}
	}

	// Token: 0x0600BD47 RID: 48455 RVA: 0x002ACC8B File Offset: 0x002AAE8B
	public void RefreshByHeadPhotoId(int headPhotoId)
	{
		this.RefreshByRoleId(headPhotoId);
	}

	// Token: 0x0600BD48 RID: 48456 RVA: 0x002ACC94 File Offset: 0x002AAE94
	public void RefreshByRoleId(int headPhotoId)
	{
		UUITexture roleTexture = base.GetTexture(0);
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(headPhotoId, false);
		if (playerHeadData != null)
		{
			roleTexture.SetUIActive(false);
			base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), roleTexture, delegate(bool _)
			{
				roleTexture.SetUIActive(true);
			});
			return;
		}
		if (headPhotoId > 0)
		{
			string roleHeadIcon = RoleConfig.Instance.GetRoleHeadIcon(headPhotoId, false);
			base.SetRoleIcon(roleHeadIcon, roleTexture, headPhotoId, null, null);
		}
	}

	// Token: 0x0600BD49 RID: 48457 RVA: 0x002ACD18 File Offset: 0x002AAF18
	public void RefreshByRoleIdUseCard(int headPhotoId)
	{
		UUITexture roleTexture = base.GetTexture(0);
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(headPhotoId, false);
		if (playerHeadData != null)
		{
			roleTexture.SetUIActive(false);
			base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), roleTexture, delegate(bool _)
			{
				roleTexture.SetUIActive(true);
			});
			return;
		}
		string card = RoleConfig.Instance.GetRoleConfig(headPhotoId).Value.Card;
		base.SetRoleIcon(card, roleTexture, headPhotoId, null, null);
	}

	// Token: 0x0600BD4A RID: 48458 RVA: 0x002ACDA9 File Offset: 0x002AAFA9
	public void SetIsGray(bool isGray)
	{
		base.GetTexture(0).SetIsGray(isGray);
	}

	// Token: 0x02007EAC RID: 32428
	private class EChildType
	{
		// Token: 0x040296A5 RID: 169637
		public const int RoleTexture = 0;
	}
}
