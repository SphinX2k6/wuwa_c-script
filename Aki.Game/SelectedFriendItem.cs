using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017AE RID: 6062
[NullableContext(2)]
[Nullable(0)]
public class SelectedFriendItem : GridProxyAbstract<int>
{
	// Token: 0x0600B0EA RID: 45290 RVA: 0x0028101C File Offset: 0x0027F21C
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

	// Token: 0x0600B0EB RID: 45291 RVA: 0x00281188 File Offset: 0x0027F388
	[NullableContext(1)]
	public void BindOnClicked(Action<int> onClickedCallback)
	{
		this.OnClickedCallback = onClickedCallback;
	}

	// Token: 0x0600B0EC RID: 45292 RVA: 0x00281194 File Offset: 0x0027F394
	protected override UniTask OnBeforeStartAsync()
	{
		SelectedFriendItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SelectedFriendItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B0ED RID: 45293 RVA: 0x002811D7 File Offset: 0x0027F3D7
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

	// Token: 0x0600B0EE RID: 45294 RVA: 0x002811F1 File Offset: 0x0027F3F1
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

	// Token: 0x0600B0EF RID: 45295 RVA: 0x00281234 File Offset: 0x0027F434
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

	// Token: 0x0600B0F0 RID: 45296 RVA: 0x00281274 File Offset: 0x0027F474
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

	// Token: 0x0600B0F1 RID: 45297 RVA: 0x002812F0 File Offset: 0x0027F4F0
	private void RefreshLevel()
	{
		int playerLevel = this.FriendData.PlayerLevel;
		UUIText text = base.GetText(5);
		LguiUtil.Instance.SetLocalText(text, "LevelShow", new <>z__ReadOnlySingleElementList<object>(playerLevel));
	}

	// Token: 0x0600B0F2 RID: 45298 RVA: 0x0028132C File Offset: 0x0027F52C
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

	// Token: 0x0600B0F3 RID: 45299 RVA: 0x002813C9 File Offset: 0x0027F5C9
	private void RefreshShieldState()
	{
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x0600B0F4 RID: 45300 RVA: 0x002813D8 File Offset: 0x0027F5D8
	private void RefreshPlayerTitle()
	{
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Refresh(new int?(this.FriendData.PlayerTitleId), new int?(this.FriendData.PlayerTitleStarLevel), new int?(this.FriendData.PlayerSex));
	}

	// Token: 0x0600B0F5 RID: 45301 RVA: 0x00281425 File Offset: 0x0027F625
	private void OnClickSelectedButton()
	{
		Action<int> onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback(this.FriendData.PlayerId);
	}

	// Token: 0x0400503D RID: 20541
	private FriendData FriendData;

	// Token: 0x0400503E RID: 20542
	private PlayerTitleItem TitleItem;

	// Token: 0x0400503F RID: 20543
	private Action<int> OnClickedCallback;

	// Token: 0x02007DC6 RID: 32198
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040292D0 RID: 168656
		public const int SelectedButton = 0;

		// Token: 0x040292D1 RID: 168657
		public const int RoleTexture = 1;

		// Token: 0x040292D2 RID: 168658
		public const int NameText = 2;

		// Token: 0x040292D3 RID: 168659
		public const int RemarkText = 3;

		// Token: 0x040292D4 RID: 168660
		public const int OnlineText = 4;

		// Token: 0x040292D5 RID: 168661
		public const int LevelText = 5;

		// Token: 0x040292D6 RID: 168662
		public const int ShieldItem = 6;

		// Token: 0x040292D7 RID: 168663
		public const int PlayerTitleItem = 7;
	}
}
