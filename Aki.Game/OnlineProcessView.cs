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

// Token: 0x020022F4 RID: 8948
[NullableContext(2)]
[Nullable(0)]
public class OnlineProcessView : UiViewBase
{
	// Token: 0x06011A39 RID: 72249 RVA: 0x0045472D File Offset: 0x0045292D
	[NullableContext(1)]
	public OnlineProcessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011A3A RID: 72250 RVA: 0x00454738 File Offset: 0x00452938
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

	// Token: 0x06011A3B RID: 72251 RVA: 0x00454A60 File Offset: 0x00452C60
	private void OnClickXboxButton()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		string text = (cachePlayerData != null) ? cachePlayerData.ThirdPartyUserId : null;
		if (!string.IsNullOrEmpty(text))
		{
			KuroSdkController.Instance.OpenProfileCard(text);
		}
	}

	// Token: 0x06011A3C RID: 72252 RVA: 0x00454A98 File Offset: 0x00452C98
	protected override UniTask OnBeforeStartAsync()
	{
		OnlineProcessView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<OnlineProcessView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011A3D RID: 72253 RVA: 0x00454ADC File Offset: 0x00452CDC
	protected override void OnStart()
	{
		this.HeadPhotoItem = new PlayerHeadItem(base.GetItem(0).GetOwner());
		base.GetText(4).SetText("", true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "OnlineProcessTitle", Array.Empty<object>());
		this.RefreshPersonalOptionItemLayout();
		this.UpdatePlayerDataShow();
	}

	// Token: 0x06011A3E RID: 72254 RVA: 0x00454B3C File Offset: 0x00452D3C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshShieldState));
	}

	// Token: 0x06011A3F RID: 72255 RVA: 0x00454BA0 File Offset: 0x00452DA0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateFriendViewShow, new Action(this.CallBackUpdateFriendViewShow));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshShieldState));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshShieldState));
	}

	// Token: 0x06011A40 RID: 72256 RVA: 0x00454C04 File Offset: 0x00452E04
	private void RefreshPersonalOptionItemLayout()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
		}
		this.PersonalOptionItemLayout = new GenericLayoutNew<PersonalOptionItem>(base.GetGridLayout(9), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PersonalOptionItem>(this.InitPersonalOptionItem), null);
		this.PersonalOptionItemLayout.RebuildLayoutByDataNew<int>(this.GetOptionDataList(), null);
	}

	// Token: 0x06011A41 RID: 72257 RVA: 0x00454C60 File Offset: 0x00452E60
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

	// Token: 0x06011A42 RID: 72258 RVA: 0x00454CD4 File Offset: 0x00452ED4
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

	// Token: 0x06011A43 RID: 72259 RVA: 0x00454D8C File Offset: 0x00452F8C
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

	// Token: 0x06011A44 RID: 72260 RVA: 0x00454E08 File Offset: 0x00453008
	public void RefreshMute()
	{
		IOnlinePlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
		bool uiactive = ChatModel.Instance.IsInMute(cachePlayerData.PlayerId);
		base.GetItem(8).SetUIActive(uiactive);
	}

	// Token: 0x06011A45 RID: 72261 RVA: 0x00454E40 File Offset: 0x00453040
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

	// Token: 0x06011A46 RID: 72262 RVA: 0x00454EF4 File Offset: 0x004530F4
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

	// Token: 0x06011A47 RID: 72263 RVA: 0x00454F48 File Offset: 0x00453148
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

	// Token: 0x06011A48 RID: 72264 RVA: 0x00455070 File Offset: 0x00453270
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

	// Token: 0x06011A49 RID: 72265 RVA: 0x004550E4 File Offset: 0x004532E4
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

	// Token: 0x06011A4A RID: 72266 RVA: 0x00455140 File Offset: 0x00453340
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

	// Token: 0x06011A4B RID: 72267 RVA: 0x00455208 File Offset: 0x00453408
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

	// Token: 0x06011A4C RID: 72268 RVA: 0x00455287 File Offset: 0x00453487
	private void OnClickChatBtn()
	{
		UiManager.Instance.CloseView(EUiViewName.OnlineProcessView, null);
		ChatController.Instance.OpenFriendChat(OnlineModel.Instance.CachePlayerData.PlayerId);
	}

	// Token: 0x06011A4D RID: 72269 RVA: 0x004552B2 File Offset: 0x004534B2
	private void CallBackUpdateFriendViewShow()
	{
		if (OnlineModel.Instance.CachePlayerData == null)
		{
			base.CloseMe(null);
			return;
		}
		this.UpdatePlayerDataShow();
	}

	// Token: 0x06011A4E RID: 72270 RVA: 0x004552CE File Offset: 0x004534CE
	protected override void OnBeforeDestroy()
	{
		if (this.PersonalOptionItemLayout != null)
		{
			this.PersonalOptionItemLayout.ClearChildren();
			this.PersonalOptionItemLayout = null;
		}
	}

	// Token: 0x040085D5 RID: 34261
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<PersonalOptionItem> PersonalOptionItemLayout;

	// Token: 0x040085D6 RID: 34262
	private PersonalOptionItem UnShieldBtn;

	// Token: 0x040085D7 RID: 34263
	private PersonalOptionItem ShieldBtn;

	// Token: 0x040085D8 RID: 34264
	private PersonalOptionItem BlockBtn;

	// Token: 0x040085D9 RID: 34265
	private PersonalOptionItem DeleteFriendBtn;

	// Token: 0x040085DA RID: 34266
	private PersonalOptionItem ReportBtn;

	// Token: 0x040085DB RID: 34267
	private PersonalOptionItem LookCardBtn;

	// Token: 0x040085DC RID: 34268
	private PersonalOptionItem ChangeRemarkBtn;

	// Token: 0x040085DD RID: 34269
	private PlayerHeadItem HeadPhotoItem;

	// Token: 0x040085DE RID: 34270
	private PlayerTitleItem TitleItem;

	// Token: 0x02008874 RID: 34932
	[NullableContext(0)]
	private enum EOnlineProcessViewComponents
	{
		// Token: 0x0402C584 RID: 181636
		HeadPhotoItem,
		// Token: 0x0402C585 RID: 181637
		HeadFrameSprite,
		// Token: 0x0402C586 RID: 181638
		NameText,
		// Token: 0x0402C587 RID: 181639
		BracketNameParent,
		// Token: 0x0402C588 RID: 181640
		BracketNameText,
		// Token: 0x0402C589 RID: 181641
		LevelNumberText,
		// Token: 0x0402C58A RID: 181642
		ChatBtn,
		// Token: 0x0402C58B RID: 181643
		LevelText,
		// Token: 0x0402C58C RID: 181644
		BlockShowItem,
		// Token: 0x0402C58D RID: 181645
		GirdLayout,
		// Token: 0x0402C58E RID: 181646
		Title,
		// Token: 0x0402C58F RID: 181647
		SignText,
		// Token: 0x0402C590 RID: 181648
		PlayStationItem,
		// Token: 0x0402C591 RID: 181649
		PlayStationText,
		// Token: 0x0402C592 RID: 181650
		PlayerTitleItem,
		// Token: 0x0402C593 RID: 181651
		PlayStationTexture,
		// Token: 0x0402C594 RID: 181652
		PcItem,
		// Token: 0x0402C595 RID: 181653
		TexCard,
		// Token: 0x0402C596 RID: 181654
		XboxButton,
		// Token: 0x0402C597 RID: 181655
		XboxText
	}
}
