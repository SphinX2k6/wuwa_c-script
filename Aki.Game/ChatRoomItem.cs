using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000C63 RID: 3171
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ChatRoomItem : GridProxyAbstract<ChatRoom>
{
	// Token: 0x060084AB RID: 33963 RVA: 0x0028A724 File Offset: 0x00288924
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

	// Token: 0x060084AC RID: 33964 RVA: 0x0028A8D4 File Offset: 0x00288AD4
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(4);
		this.PlayerHeadItem = new PlayerHeadItem(item.GetOwner());
	}

	// Token: 0x060084AD RID: 33965 RVA: 0x0028A8FA File Offset: 0x00288AFA
	protected override void OnBeforeDestroy()
	{
		this.FriendData = null;
		this.ChatRoomType = null;
		this.OwnerId = 0;
	}

	// Token: 0x060084AE RID: 33966 RVA: 0x0028A916 File Offset: 0x00288B16
	public override void Clear()
	{
	}

	// Token: 0x060084AF RID: 33967 RVA: 0x0028A918 File Offset: 0x00288B18
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

	// Token: 0x060084B0 RID: 33968 RVA: 0x0028A940 File Offset: 0x00288B40
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

	// Token: 0x060084B1 RID: 33969 RVA: 0x0028AA78 File Offset: 0x00288C78
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

	// Token: 0x060084B2 RID: 33970 RVA: 0x0028AB04 File Offset: 0x00288D04
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

	// Token: 0x060084B3 RID: 33971 RVA: 0x0028AB9C File Offset: 0x00288D9C
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

	// Token: 0x060084B4 RID: 33972 RVA: 0x0028ABB7 File Offset: 0x00288DB7
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(EToggleState.ETT_UnChecked);
	}

	// Token: 0x060084B5 RID: 33973 RVA: 0x0028ABC0 File Offset: 0x00288DC0
	public void RefreshIsOnline(PrivateChatRoom privateChatRoom)
	{
		UUIItem item = base.GetItem(6);
		bool flag = privateChatRoom.IsOnline();
		item.SetUIActive(!flag);
		base.GetSprite(5).SetIsGray(!flag);
		base.GetItem(7).SetUIActive(flag);
		this.PlayerHeadItem.SetIsGray(!flag);
	}

	// Token: 0x060084B6 RID: 33974 RVA: 0x0028AC10 File Offset: 0x00288E10
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

	// Token: 0x060084B7 RID: 33975 RVA: 0x0028AD04 File Offset: 0x00288F04
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

	// Token: 0x060084B8 RID: 33976 RVA: 0x0028AD94 File Offset: 0x00288F94
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

	// Token: 0x060084B9 RID: 33977 RVA: 0x0028ADD6 File Offset: 0x00288FD6
	[NullableContext(1)]
	public void BindOnClicked(Action<EChatRoomType, int> onClicked)
	{
		this.OnClickedCallback = onClicked;
	}

	// Token: 0x060084BA RID: 33978 RVA: 0x0028ADE0 File Offset: 0x00288FE0
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

	// Token: 0x040050DD RID: 20701
	private EChatRoomType? ChatRoomType;

	// Token: 0x040050DE RID: 20702
	private int OwnerId;

	// Token: 0x040050DF RID: 20703
	private FriendData FriendData;

	// Token: 0x040050E0 RID: 20704
	private PlayerHeadItem PlayerHeadItem;

	// Token: 0x040050E1 RID: 20705
	private Action<EChatRoomType, int> OnClickedCallback;

	// Token: 0x02006F48 RID: 28488
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040245E8 RID: 148968
		public const int FriendExtendsToggle = 0;

		// Token: 0x040245E9 RID: 148969
		public const int FriendNameText = 1;

		// Token: 0x040245EA RID: 148970
		public const int RedDotItem = 2;

		// Token: 0x040245EB RID: 148971
		public const int ShieldItem = 3;

		// Token: 0x040245EC RID: 148972
		public const int PlayerHeadItem = 4;

		// Token: 0x040245ED RID: 148973
		public const int TeamHeadSprite = 5;

		// Token: 0x040245EE RID: 148974
		public const int OfflineState = 6;

		// Token: 0x040245EF RID: 148975
		public const int OnlineState = 7;

		// Token: 0x040245F0 RID: 148976
		public const int ThirdPartyTexture = 8;

		// Token: 0x040245F1 RID: 148977
		public const int PcItem = 9;
	}
}
