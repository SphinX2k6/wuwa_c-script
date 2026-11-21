using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C67 RID: 3175
[NullableContext(2)]
[Nullable(0)]
public class SelectedFriendItem : GridProxyAbstract<int>
{
	// Token: 0x060084D2 RID: 34002 RVA: 0x0028B5B4 File Offset: 0x002897B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickSelectedButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060084D3 RID: 34003 RVA: 0x0028B720 File Offset: 0x00289920
	[NullableContext(1)]
	public void BindOnClicked(Action<int> onClickedCallback)
	{
		this.OnClickedCallback = onClickedCallback;
	}

	// Token: 0x060084D4 RID: 34004 RVA: 0x0028B72C File Offset: 0x0028992C
	protected override UniTask OnBeforeStartAsync()
	{
		SelectedFriendItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SelectedFriendItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060084D5 RID: 34005 RVA: 0x0028B76F File Offset: 0x0028996F
	protected override void OnBeforeDestroy()
	{
		this.OnClickedCallback = null;
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Destroy(null);
	}

	// Token: 0x060084D6 RID: 34006 RVA: 0x0028B789 File Offset: 0x00289989
	public override void Refresh(int playerId, bool isSelected, int gridIndex)
	{
		this.FriendData = FriendModel.Instance.GetFriendById(playerId);
		if (this.FriendData == null)
		{
			return;
		}
		this.RefreshRoleTexture();
		this.RefreshName();
		this.RefreshLevel();
		this.RefreshOnlineState();
		this.RefreshShieldState();
		this.RefreshPlayerTitle();
	}

	// Token: 0x060084D7 RID: 34007 RVA: 0x0028B7CC File Offset: 0x002899CC
	private void RefreshRoleTexture()
	{
		int playerHeadPhoto = this.FriendData.PlayerHeadPhoto;
		UUITexture texture = base.GetTexture(1);
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(playerHeadPhoto, false);
		if (playerHeadData != null)
		{
			base.SetTextureShowUntilLoaded(playerHeadData.GetRoleHeadIconCircle(), texture, null);
		}
	}

	// Token: 0x060084D8 RID: 34008 RVA: 0x0028B80C File Offset: 0x00289A0C
	private void RefreshName()
	{
		UUIText text = base.GetText(2);
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
		if (!string.IsNullOrEmpty(this.FriendData.FriendRemark))
		{
			text.SetText(this.FriendData.FriendRemark, true);
			if (text != null)
			{
				text.SetColor(ChatDefine.playerMarkNameColor);
				return;
			}
		}
		else
		{
			text.SetText(this.FriendData.PlayerName, true);
			if (text != null)
			{
				text.SetColor(ChatDefine.playerRealNameColor);
			}
		}
	}

	// Token: 0x060084D9 RID: 34009 RVA: 0x0028B888 File Offset: 0x00289A88
	private void RefreshLevel()
	{
		int playerLevel = this.FriendData.PlayerLevel;
		UUIText text = base.GetText(5);
		LguiUtil.Instance.SetLocalText(text, "LevelShow", new <>z__ReadOnlySingleElementList<object>(playerLevel));
	}

	// Token: 0x060084DA RID: 34010 RVA: 0x0028B8C4 File Offset: 0x00289AC4
	private void RefreshOnlineState()
	{
		bool playerIsOnline = this.FriendData.PlayerIsOnline;
		UUIText text = base.GetText(4);
		FColor color = FColor.FromHex(playerIsOnline ? "00D67E" : "D64600");
		text.SetColor(color);
		if (playerIsOnline)
		{
			LguiUtil.Instance.SetLocalText(text, "FriendOnline", Array.Empty<object>());
			return;
		}
		if (this.FriendData.PlayerLastOfflineTime == 0L)
		{
			text.SetText("", true);
			return;
		}
		int offlineDay = this.FriendData.GetOfflineDay();
		string offlineTimeString = FriendController.Instance.GetOfflineTimeString(offlineDay);
		LguiUtil.Instance.SetLocalText(text, offlineTimeString, new <>z__ReadOnlySingleElementList<object>(offlineDay));
	}

	// Token: 0x060084DB RID: 34011 RVA: 0x0028B961 File Offset: 0x00289B61
	private void RefreshShieldState()
	{
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x060084DC RID: 34012 RVA: 0x0028B970 File Offset: 0x00289B70
	private void RefreshPlayerTitle()
	{
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Refresh(new int?(this.FriendData.PlayerTitleId), new int?(this.FriendData.PlayerTitleStarLevel), new int?(this.FriendData.PlayerSex));
	}

	// Token: 0x060084DD RID: 34013 RVA: 0x0028B9BD File Offset: 0x00289BBD
	private void OnClickSelectedButton()
	{
		Action<int> onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback(this.FriendData.PlayerId);
	}

	// Token: 0x040050E7 RID: 20711
	private FriendData FriendData;

	// Token: 0x040050E8 RID: 20712
	private PlayerTitleItem TitleItem;

	// Token: 0x040050E9 RID: 20713
	private Action<int> OnClickedCallback;

	// Token: 0x02006F4C RID: 28492
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040245FB RID: 148987
		public const int SelectedButton = 0;

		// Token: 0x040245FC RID: 148988
		public const int RoleTexture = 1;

		// Token: 0x040245FD RID: 148989
		public const int NameText = 2;

		// Token: 0x040245FE RID: 148990
		public const int RemarkText = 3;

		// Token: 0x040245FF RID: 148991
		public const int OnlineText = 4;

		// Token: 0x04024600 RID: 148992
		public const int LevelText = 5;

		// Token: 0x04024601 RID: 148993
		public const int ShieldItem = 6;

		// Token: 0x04024602 RID: 148994
		public const int PlayerTitleItem = 7;
	}
}
