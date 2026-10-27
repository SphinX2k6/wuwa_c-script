using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020017AA RID: 6058
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ChatRoomItem : GridProxyAbstract<ChatRoom>
{
	// Token: 0x0600B0C3 RID: 45251 RVA: 0x0028018C File Offset: 0x0027E38C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickFriendExtendsToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B0C4 RID: 45252 RVA: 0x0028033C File Offset: 0x0027E53C
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(4);
		this.PlayerHeadItem = new PlayerHeadItem(item.GetOwner());
	}

	// Token: 0x0600B0C5 RID: 45253 RVA: 0x00280362 File Offset: 0x0027E562
	protected override void OnBeforeDestroy()
	{
		this.FriendData = null;
		this.ChatRoomType = null;
		this.OwnerId = 0;
	}

	// Token: 0x0600B0C6 RID: 45254 RVA: 0x0028037E File Offset: 0x0027E57E
	public override void Clear()
	{
	}

	// Token: 0x0600B0C7 RID: 45255 RVA: 0x00280380 File Offset: 0x0027E580
	private void OnClickFriendExtendsToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<EChatRoomType, int> onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback(this.ChatRoomType.Value, this.OwnerId);
	}

	// Token: 0x0600B0C8 RID: 45256 RVA: 0x002803A8 File Offset: 0x0027E5A8
	[NullableContext(1)]
	public override void Refresh(ChatRoom chatRoom, bool isSelected, int gridIndex)
	{
		base.GetItem(6).SetUIActive(false);
		base.GetItem(7).SetUIActive(false);
		base.GetSprite(5).SetIsGray(false);
		PrivateChatRoom privateChatRoom = chatRoom as PrivateChatRoom;
		if (privateChatRoom != null)
		{
			int targetPlayerId = privateChatRoom.GetTargetPlayerId();
			this.FriendData = FriendModel.Instance.GetFriendById(targetPlayerId);
			if (this.FriendData == null)
			{
				return;
			}
			this.ChatRoomType = new EChatRoomType?(EChatRoomType.Private);
			this.OwnerId = this.FriendData.PlayerId;
			this.RefreshIsOnline(privateChatRoom);
		}
		else if (chatRoom is TeamChatRoom)
		{
			this.FriendData = null;
			this.ChatRoomType = new EChatRoomType?(EChatRoomType.Team);
			this.OwnerId = PlayerInfoModel.Instance.GetId().Value;
		}
		else if (chatRoom is WorldChatRoom)
		{
			this.FriendData = null;
			this.ChatRoomType = new EChatRoomType?(EChatRoomType.World);
			this.OwnerId = PlayerInfoModel.Instance.GetId().Value;
		}
		bool isShowRedDot = chatRoom.GetIsShowRedDot();
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(isShowRedDot);
		}
		this.RefreshPlayerTexture();
		this.RefreshPlayerName();
		this.RefreshMuteItem();
		this.RefreshThirdPartyItem();
		this.RefreshPcItem();
		if (isSelected)
		{
			this.SetToggleState(EToggleState.ETT_Checked);
			return;
		}
		this.SetToggleState(EToggleState.ETT_UnChecked);
	}

	// Token: 0x0600B0C9 RID: 45257 RVA: 0x002804E0 File Offset: 0x0027E6E0
	private void RefreshThirdPartyItem()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			bool flag;
			if (this.FriendData != null)
			{
				FriendData friendData = this.FriendData;
				flag = !string.IsNullOrEmpty((friendData != null) ? friendData.GetSdkUserId() : null);
			}
			else
			{
				flag = false;
			}
			bool uiactive = flag;
			UUITexture texture = base.GetTexture(8);
			if (texture != null)
			{
				texture.SetUIActive(uiactive);
			}
			string thirdPartyLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyLogoTexturePath, base.GetTexture(8), null, null);
			return;
		}
		UUITexture texture2 = base.GetTexture(8);
		if (texture2 == null)
		{
			return;
		}
		texture2.SetUIActive(false);
	}

	// Token: 0x0600B0CA RID: 45258 RVA: 0x0028056C File Offset: 0x0027E76C
	private void RefreshPcItem()
	{
		if (this.ChatRoomType == null || this.ChatRoomType.GetValueOrDefault() != EChatRoomType.Private)
		{
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			bool flag;
			if (this.FriendData != null)
			{
				FriendData friendData = this.FriendData;
				flag = !string.IsNullOrEmpty((friendData != null) ? friendData.GetSdkUserId() : null);
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			UUIItem item2 = base.GetItem(9);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag2);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(9);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600B0CB RID: 45259 RVA: 0x00280604 File Offset: 0x0027E804
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(EToggleState.ETT_Checked);
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600B0CC RID: 45260 RVA: 0x0028061F File Offset: 0x0027E81F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(EToggleState.ETT_UnChecked);
	}

	// Token: 0x0600B0CD RID: 45261 RVA: 0x00280628 File Offset: 0x0027E828
	public void RefreshIsOnline(PrivateChatRoom privateChatRoom)
	{
		UUIItem item = base.GetItem(6);
		bool flag = privateChatRoom.IsOnline();
		item.SetUIActive(!flag);
		base.GetSprite(5).SetIsGray(!flag);
		base.GetItem(7).SetUIActive(flag);
		this.PlayerHeadItem.SetIsGray(!flag);
	}

	// Token: 0x0600B0CE RID: 45262 RVA: 0x00280678 File Offset: 0x0027E878
	public void RefreshPlayerTexture()
	{
		UUISprite sprite = base.GetSprite(5);
		if (this.ChatRoomType.GetValueOrDefault() == EChatRoomType.Team)
		{
			sprite.SetUIActive(true);
			this.PlayerHeadItem.SetActive(false);
			return;
		}
		if (this.ChatRoomType.GetValueOrDefault() == EChatRoomType.World)
		{
			sprite.SetUIActive(true);
			this.PlayerHeadItem.SetActive(false);
			return;
		}
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		FriendData friendData = this.FriendData;
		int? num = (friendData != null) ? new int?(friendData.PlayerId) : PlayerInfoModel.Instance.GetId();
		if (num == null)
		{
			this.PlayerHeadItem.SetActive(false);
			return;
		}
		ChatPlayerData chatPlayerData = ChatModel.Instance.GetChatPlayerData(num.Value);
		int? num2 = (chatPlayerData != null) ? new int?(chatPlayerData.GetPlayerIcon()) : null;
		if (num2 != null)
		{
			this.PlayerHeadItem.RefreshByRoleIdUseCard(num2.Value);
			return;
		}
		this.PlayerHeadItem.RefreshByPlayerId(num.Value, true);
	}

	// Token: 0x0600B0CF RID: 45263 RVA: 0x0028076C File Offset: 0x0027E96C
	private void RefreshPlayerName()
	{
		UUIText text = base.GetText(1);
		if (this.ChatRoomType.GetValueOrDefault() == EChatRoomType.Team)
		{
			LguiUtil.Instance.SetLocalText(text, "CurrentTeam", Array.Empty<object>());
			return;
		}
		if (this.ChatRoomType.GetValueOrDefault() == EChatRoomType.World)
		{
			LguiUtil.Instance.SetLocalText(text, "CurrentTeam", Array.Empty<object>());
			return;
		}
		string friendRemark = this.FriendData.FriendRemark;
		if (StringUtils.IsEmpty(friendRemark))
		{
			string playerName = this.FriendData.PlayerName;
			text.SetText(playerName, true);
			return;
		}
		text.SetText(friendRemark, true);
	}

	// Token: 0x0600B0D0 RID: 45264 RVA: 0x002807FC File Offset: 0x0027E9FC
	public void RefreshMuteItem()
	{
		UUIItem item = base.GetItem(3);
		if (this.FriendData == null)
		{
			item.SetUIActive(false);
			return;
		}
		bool uiactive = ChatModel.Instance.IsInMute(this.FriendData.PlayerId);
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600B0D1 RID: 45265 RVA: 0x0028083E File Offset: 0x0027EA3E
	[NullableContext(1)]
	public void BindOnClicked(Action<EChatRoomType, int> onClicked)
	{
		this.OnClickedCallback = onClicked;
	}

	// Token: 0x0600B0D2 RID: 45266 RVA: 0x00280848 File Offset: 0x0027EA48
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		if (extendToggle.GetToggleState() == state)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x04005033 RID: 20531
	private EChatRoomType? ChatRoomType;

	// Token: 0x04005034 RID: 20532
	private int OwnerId;

	// Token: 0x04005035 RID: 20533
	private FriendData FriendData;

	// Token: 0x04005036 RID: 20534
	private PlayerHeadItem PlayerHeadItem;

	// Token: 0x04005037 RID: 20535
	private Action<EChatRoomType, int> OnClickedCallback;

	// Token: 0x02007DC2 RID: 32194
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040292BD RID: 168637
		public const int FriendExtendsToggle = 0;

		// Token: 0x040292BE RID: 168638
		public const int FriendNameText = 1;

		// Token: 0x040292BF RID: 168639
		public const int RedDotItem = 2;

		// Token: 0x040292C0 RID: 168640
		public const int ShieldItem = 3;

		// Token: 0x040292C1 RID: 168641
		public const int PlayerHeadItem = 4;

		// Token: 0x040292C2 RID: 168642
		public const int TeamHeadSprite = 5;

		// Token: 0x040292C3 RID: 168643
		public const int OfflineState = 6;

		// Token: 0x040292C4 RID: 168644
		public const int OnlineState = 7;

		// Token: 0x040292C5 RID: 168645
		public const int ThirdPartyTexture = 8;

		// Token: 0x040292C6 RID: 168646
		public const int PcItem = 9;
	}
}
