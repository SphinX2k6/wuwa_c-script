using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E0F RID: 3599
public class PlayerHeadItem : UiPanelBase
{
	// Token: 0x06009146 RID: 37190 RVA: 0x002B79C6 File Offset: 0x002B5BC6
	[NullableContext(1)]
	public PlayerHeadItem(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x06009147 RID: 37191 RVA: 0x002B79D8 File Offset: 0x002B5BD8
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

	// Token: 0x06009148 RID: 37192 RVA: 0x002B7A20 File Offset: 0x002B5C20
	public void RefreshByPlayerId(int playerId, bool useCard = false)
	{
		this.RefreshPlayerTexture(playerId, useCard);
	}

	// Token: 0x06009149 RID: 37193 RVA: 0x002B7A2C File Offset: 0x002B5C2C
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

	// Token: 0x0600914A RID: 37194 RVA: 0x002B7ACF File Offset: 0x002B5CCF
	public void RefreshByHeadPhotoId(int headPhotoId)
	{
		this.RefreshByRoleId(headPhotoId);
	}

	// Token: 0x0600914B RID: 37195 RVA: 0x002B7AD8 File Offset: 0x002B5CD8
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

	// Token: 0x0600914C RID: 37196 RVA: 0x002B7B5C File Offset: 0x002B5D5C
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

	// Token: 0x0600914D RID: 37197 RVA: 0x002B7BED File Offset: 0x002B5DED
	public void SetIsGray(bool isGray)
	{
		base.GetTexture(0).SetIsGray(isGray);
	}

	// Token: 0x0200703B RID: 28731
	private class EChildType
	{
		// Token: 0x040249E2 RID: 149986
		public const int RoleTexture = 0;
	}
}
