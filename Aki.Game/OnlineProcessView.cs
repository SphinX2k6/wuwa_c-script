using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017D8 RID: 6104
[NullableContext(2)]
[Nullable(0)]
public class OnlineProcessView : UiViewBase
{
	// Token: 0x0600EED1 RID: 61137 RVA: 0x004613F9 File Offset: 0x0045F5F9
	[NullableContext(1)]
	public OnlineProcessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EED2 RID: 61138 RVA: 0x00461404 File Offset: 0x0045F604
	protected unsafe override void OnRegisterComponent()
	{
		int num = 20;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickChatBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnClickXboxButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600EED3 RID: 61139 RVA: 0x0046172C File Offset: 0x0045F92C
	private void OnClickXboxButton()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		string text = (cachePlayerData != null) ? cachePlayerData.ThirdPartyUserId : null;
		if (!string.IsNullOrEmpty(text))
		{
			KuroSdkController.Instance.OpenProfileCard(text);
		}
	}

	// Token: 0x0600EED4 RID: 61140 RVA: 0x00461764 File Offset: 0x0045F964
	protected override UniTask OnBeforeStartAsync()
	{
		OnlineProcessView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<OnlineProcessView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EED5 RID: 61141 RVA: 0x004617A8 File Offset: 0x0045F9A8
	protected override void OnStart()
	{
		this.HeadPhotoItem = new PlayerHeadItem(base.GetItem(0).GetOwner());
		base.GetText(4).SetText("", true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "OnlineProcessTitle", Array.Empty<object>());
		this.RefreshPersonalOptionItemLayout();
		this.UpdatePlayerDataShow();
	}

	// Token: 0x0600EED6 RID: 61142 RVA: 0x00461808 File Offset: 0x0045FA08
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshShieldState));
	}

	// Token: 0x0600EED7 RID: 61143 RVA: 0x0046186C File Offset: 0x0045FA6C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshShieldState));
	}

	// Token: 0x0600EED8 RID: 61144 RVA: 0x004618D0 File Offset: 0x0045FAD0
	private void RefreshPersonalOptionItemLayout()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
		}
		this.PersonalOptionItemLayout = new GenericLayoutNew<PersonalOptionItem>(base.GetGridLayout(9), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PersonalOptionItem>(this.InitPersonalOptionItem), null);
		this.PersonalOptionItemLayout.RebuildLayoutByDataNew<int>(this.GetOptionDataList(), null);
	}

	// Token: 0x0600EED9 RID: 61145 RVA: 0x0046192C File Offset: 0x0045FB2C
	[NullableContext(1)]
	private List<int> GetOptionDataList()
	{
		List<int> processViewFunctionList = FriendConfig.Instance.GetProcessViewFunctionList();
		List<int> list = new List<int>();
		foreach (int num in processViewFunctionList)
		{
			if (num != 12 || FunctionModel.Instance.IsOpen(10060))
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x0600EEDA RID: 61146 RVA: 0x004619A0 File Offset: 0x0045FBA0
	[NullableContext(1)]
	private ILayoutItem<PersonalOptionItem> InitPersonalOptionItem(object optionId, UUIItem uiItem, int index)
	{
		PersonalOptionItem personalOptionItem = new PersonalOptionItem(uiItem);
		personalOptionItem.Refresh((int)optionId, false, index);
		if ((EPersonalOptionDefine)optionId == EPersonalOptionDefine.UnShield)
		{
			this.UnShieldBtn = personalOptionItem;
		}
		else if ((EPersonalOptionDefine)optionId == EPersonalOptionDefine.Shield)
		{
			this.ShieldBtn = personalOptionItem;
		}
		else if ((EPersonalOptionDefine)optionId == EPersonalOptionDefine.Block)
		{
			this.BlockBtn = personalOptionItem;
		}
		else if ((EPersonalOptionDefine)optionId == EPersonalOptionDefine.DeleteFriend)
		{
			this.DeleteFriendBtn = personalOptionItem;
		}
		else if ((EPersonalOptionDefine)optionId == EPersonalOptionDefine.Report)
		{
			this.ReportBtn = personalOptionItem;
		}
		else if ((EPersonalOptionDefine)optionId == EPersonalOptionDefine.LookCard)
		{
			this.LookCardBtn = personalOptionItem;
		}
		else if ((EPersonalOptionDefine)optionId == EPersonalOptionDefine.ChangeRemark)
		{
			this.ChangeRemarkBtn = personalOptionItem;
		}
		return new LayoutItem<PersonalOptionItem>
		{
			Key = index,
			Value = personalOptionItem
		};
	}

	// Token: 0x0600EEDB RID: 61147 RVA: 0x00461A58 File Offset: 0x0045FC58
	private void UpdatePlayerDataShow()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		FriendModel.Instance.SelectedPlayerId = new int?(cachePlayerData.PlayerId);
		FriendModel.Instance.SetCurrentOperationPlayerId(cachePlayerData.PlayerId);
		this.ShowNecessaryItem();
		this.HeadPhotoItem.RefreshByHeadPhotoId(cachePlayerData.HeadId);
		base.GetText(5).SetText(cachePlayerData.Level.ToString(), true);
		this.RefreshShieldState(cachePlayerData.PlayerId);
	}

	// Token: 0x0600EEDC RID: 61148 RVA: 0x00461AD4 File Offset: 0x0045FCD4
	public void RefreshMute()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		bool uiactive = ChatModel.Instance.IsInMute(cachePlayerData.PlayerId);
		base.GetItem(8).SetUIActive(uiactive);
	}

	// Token: 0x0600EEDD RID: 61149 RVA: 0x00461B0C File Offset: 0x0045FD0C
	private void RefreshName()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		bool flag = FriendModel.Instance.IsMyFriend(cachePlayerData.PlayerId);
		UUIText text = base.GetText(2);
		if (!flag)
		{
			text.SetText((cachePlayerData != null) ? cachePlayerData.Name : null, true);
			text.useChangeColor = false;
			return;
		}
		FriendData friendById = FriendModel.Instance.GetFriendById(cachePlayerData.PlayerId);
		string text2 = (friendById != null) ? friendById.FriendRemark : null;
		if (text2 != null && text2 != "")
		{
			text.SetText("(" + text2 + ")", true);
			text.useChangeColor = true;
			return;
		}
		text.SetText((cachePlayerData != null) ? cachePlayerData.Name : null, true);
		text.useChangeColor = false;
	}

	// Token: 0x0600EEDE RID: 61150 RVA: 0x00461BC0 File Offset: 0x0045FDC0
	private void RefreshSign()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		string text = (cachePlayerData != null) ? cachePlayerData.Signature : null;
		UUIText text2 = base.GetText(11);
		if (text != null && text != "")
		{
			text2.SetText(text, true);
			return;
		}
		text2.SetText("", true);
	}

	// Token: 0x0600EEDF RID: 61151 RVA: 0x00461C14 File Offset: 0x0045FE14
	private void RefreshPlayStationItem()
	{
		if (KuroSdkController.Instance.NeedShowThirdPartyId())
		{
			IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
			bool flag = ((cachePlayerData != null) ? cachePlayerData.ThirdPartyUserId : null) != "";
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(flag && Info.Instance.IsPs5Platform());
			}
			UUIButtonComponent button = base.GetButton(18);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag && Info.Instance.IsXboxPlatform());
			}
			string thirdPartyUserId = OnlineModel.Instance.CachePlayerData.ThirdPartyUserId;
			if (flag && Info.Instance.IsPs5Platform())
			{
				UUIText text = base.GetText(13);
				if (text != null)
				{
					text.SetText(thirdPartyUserId, true);
				}
			}
			else if (flag && Info.Instance.IsXboxPlatform())
			{
				UUIText text2 = base.GetText(19);
				if (text2 != null)
				{
					text2.SetText(thirdPartyUserId, true);
				}
			}
			UUIItem item2 = base.GetItem(16);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
			return;
		}
		else
		{
			UUIItem item3 = base.GetItem(12);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(16);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600EEE0 RID: 61152 RVA: 0x00461D3C File Offset: 0x0045FF3C
	private void RefreshPlayerTitle()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		PlayerTitleItem titleItem = this.TitleItem;
		if (titleItem == null)
		{
			return;
		}
		titleItem.Refresh((cachePlayerData != null) ? new int?(cachePlayerData.PlayerTitleId) : null, (cachePlayerData != null) ? new int?(cachePlayerData.PlayerTitleStarLevel) : null, (cachePlayerData != null) ? new int?(cachePlayerData.Sex) : null);
	}

	// Token: 0x0600EEE1 RID: 61153 RVA: 0x00461DB0 File Offset: 0x0045FFB0
	private void RefreshPlayerCard()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		if (cachePlayerData == null)
		{
			return;
		}
		BackgroundCard? config = ConfigBackgroundCardById.GetConfig(cachePlayerData.CurUsingCardId, true);
		if (config != null)
		{
			base.SetTextureByPath(config.Value.FunctionViewCardPath, base.GetTexture(17), null, null);
		}
	}

	// Token: 0x0600EEE2 RID: 61154 RVA: 0x00461E0C File Offset: 0x0046000C
	private void ShowNecessaryItem()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		this.RefreshName();
		this.RefreshSign();
		this.RefreshPlayStationItem();
		this.RefreshPlayerTitle();
		this.RefreshPlayerCard();
		bool uiactive = FriendModel.Instance.IsMyFriend(cachePlayerData.PlayerId);
		this.ChangeRemarkBtn.GetRootItem().SetUIActive(uiactive);
		this.ShieldBtn.GetRootItem().SetUIActive(false);
		this.ReportBtn.GetRootItem().SetUIActive(true);
		this.BlockBtn.GetRootItem().SetUIActive(false);
		this.DeleteFriendBtn.GetRootItem().SetUIActive(uiactive);
		base.GetButton(6).RootUIComp.Get().SetUIActive(uiactive);
		PersonalOptionItem lookCardBtn = this.LookCardBtn;
		if (lookCardBtn == null)
		{
			return;
		}
		lookCardBtn.SetActive(true);
	}

	// Token: 0x0600EEE3 RID: 61155 RVA: 0x00461ED4 File Offset: 0x004600D4
	private void RefreshShieldState(int playerId)
	{
		this.UnShieldBtn.GetRootItem().SetUIActive(false);
		this.ShieldBtn.GetRootItem().SetUIActive(false);
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		int? num = (cachePlayerData != null) ? new int?(cachePlayerData.PlayerId) : null;
		if (playerId == num.GetValueOrDefault() & num != null)
		{
			ChatModel.Instance.IsInMute(cachePlayerData.PlayerId);
		}
		this.RefreshMute();
	}

	// Token: 0x0600EEE4 RID: 61156 RVA: 0x00461F53 File Offset: 0x00460153
	private void OnClickChatBtn()
	{
		UiManager.Instance.CloseView(EUiViewName.OnlineProcessView, null);
		ChatController.Instance.OpenFriendChat(OnlineModel.Instance.CachePlayerData.PlayerId);
	}

	// Token: 0x0600EEE5 RID: 61157 RVA: 0x00461F7E File Offset: 0x0046017E
	private void CallBackUpdateFriendViewShow()
	{
		if (OnlineModel.Instance.CachePlayerData == null)
		{
			base.CloseMe(null);
			return;
		}
		this.UpdatePlayerDataShow();
	}

	// Token: 0x0600EEE6 RID: 61158 RVA: 0x00461F9A File Offset: 0x0046019A
	protected override void OnBeforeDestroy()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
			this.PersonalOptionItemLayout = null;
		}
	}

	// Token: 0x04008713 RID: 34579
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<PersonalOptionItem> PersonalOptionItemLayout;

	// Token: 0x04008714 RID: 34580
	private PersonalOptionItem UnShieldBtn;

	// Token: 0x04008715 RID: 34581
	private PersonalOptionItem ShieldBtn;

	// Token: 0x04008716 RID: 34582
	private PersonalOptionItem BlockBtn;

	// Token: 0x04008717 RID: 34583
	private PersonalOptionItem DeleteFriendBtn;

	// Token: 0x04008718 RID: 34584
	private PersonalOptionItem ReportBtn;

	// Token: 0x04008719 RID: 34585
	private PersonalOptionItem LookCardBtn;

	// Token: 0x0400871A RID: 34586
	private PersonalOptionItem ChangeRemarkBtn;

	// Token: 0x0400871B RID: 34587
	private PlayerHeadItem HeadPhotoItem;

	// Token: 0x0400871C RID: 34588
	private PlayerTitleItem TitleItem;

	// Token: 0x020079F8 RID: 31224
	[NullableContext(0)]
	private enum EOnlineProcessViewComponents
	{
		// Token: 0x04027886 RID: 161926
		HeadPhotoItem,
		// Token: 0x04027887 RID: 161927
		HeadFrameSprite,
		// Token: 0x04027888 RID: 161928
		NameText,
		// Token: 0x04027889 RID: 161929
		BracketNameParent,
		// Token: 0x0402788A RID: 161930
		BracketNameText,
		// Token: 0x0402788B RID: 161931
		LevelNumberText,
		// Token: 0x0402788C RID: 161932
		ChatBtn,
		// Token: 0x0402788D RID: 161933
		LevelText,
		// Token: 0x0402788E RID: 161934
		BlockShowItem,
		// Token: 0x0402788F RID: 161935
		GirdLayout,
		// Token: 0x04027890 RID: 161936
		Title,
		// Token: 0x04027891 RID: 161937
		SignText,
		// Token: 0x04027892 RID: 161938
		PlayStationItem,
		// Token: 0x04027893 RID: 161939
		PlayStationText,
		// Token: 0x04027894 RID: 161940
		PlayerTitleItem,
		// Token: 0x04027895 RID: 161941
		PlayStationTexture,
		// Token: 0x04027896 RID: 161942
		PcItem,
		// Token: 0x04027897 RID: 161943
		TexCard,
		// Token: 0x04027898 RID: 161944
		XboxButton,
		// Token: 0x04027899 RID: 161945
		XboxText
	}
}
