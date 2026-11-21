using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010FE RID: 4350
[NullableContext(1)]
[Nullable(0)]
public class FriendSearchView : UiViewBase
{
	// Token: 0x0600ADF9 RID: 44537 RVA: 0x0033473D File Offset: 0x0033293D
	public FriendSearchView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600ADFA RID: 44538 RVA: 0x00334754 File Offset: 0x00332954
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickSearchConfirmBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickSearchTypeButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600ADFB RID: 44539 RVA: 0x0033496B File Offset: 0x00332B6B
	private void OnClickSearchTypeButton()
	{
		this.CurrentSearchType = ((this.CurrentSearchType == FriendSearchView.ECurrentSearchType.Uid) ? FriendSearchView.ECurrentSearchType.ThirdPartyId : FriendSearchView.ECurrentSearchType.Uid);
		this.RefreshSearchTypeButton();
		this.RefreshPlaceHolderText();
		this.RefreshSearchColor();
		this.RefreshDescText();
	}

	// Token: 0x0600ADFC RID: 44540 RVA: 0x00334998 File Offset: 0x00332B98
	private void RefreshSearchColor()
	{
		if (this.CurrentSearchType == FriendSearchView.ECurrentSearchType.ThirdPartyId)
		{
			string thirdPartySearchColor = UiResourceConfig.Instance.GetThirdPartySearchColor(EThirdPartySearchColorSet.Set1);
			string thirdPartySearchColor2 = UiResourceConfig.Instance.GetThirdPartySearchColor(EThirdPartySearchColorSet.Set2);
			base.GetSprite(10).SetColor(FColor.FromHex(thirdPartySearchColor));
			base.GetSprite(11).SetColor(FColor.FromHex(thirdPartySearchColor2));
			return;
		}
		base.GetSprite(10).SetColor(FColor.FromHex("E8E8E6FF"));
		base.GetSprite(11).SetColor(FColor.FromHex("FFFFFFFF"));
	}

	// Token: 0x0600ADFD RID: 44541 RVA: 0x00334A1C File Offset: 0x00332C1C
	private void RefreshPlaceHolderText()
	{
		if (KuroSdkController.Instance.SupportSwitchFriendSearchByThirdPartyId())
		{
			string textStringId = "";
			if (this.CurrentSearchType == FriendSearchView.ECurrentSearchType.ThirdPartyId)
			{
				if (Info.Instance.IsPs5Platform())
				{
					textStringId = "Search_PSN_ID_Tips";
				}
				else if (Info.Instance.IsXboxPlatform())
				{
					textStringId = "Search_Xbox_ID_Tips";
				}
			}
			else if (this.CurrentSearchType == FriendSearchView.ECurrentSearchType.Uid)
			{
				textStringId = "Search_UID_Tips";
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId, Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Search_UID_Tips", Array.Empty<object>());
	}

	// Token: 0x0600ADFE RID: 44542 RVA: 0x00334AB0 File Offset: 0x00332CB0
	private void RefreshDescText()
	{
		if (KuroSdkController.Instance.SupportSwitchFriendSearchByThirdPartyId())
		{
			string textStringId = "";
			if (this.CurrentSearchType == FriendSearchView.ECurrentSearchType.ThirdPartyId)
			{
				if (Info.Instance.IsPs5Platform())
				{
					textStringId = "Search_PSN_ID_Result";
				}
				else if (Info.Instance.IsXboxPlatform())
				{
					textStringId = "Search_Xbox_ID_Result";
				}
			}
			else if (this.CurrentSearchType == FriendSearchView.ECurrentSearchType.Uid)
			{
				textStringId = "Search_UID_Result";
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), textStringId, Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "Search_UID_Result", Array.Empty<object>());
	}

	// Token: 0x0600ADFF RID: 44543 RVA: 0x00334B44 File Offset: 0x00332D44
	private void RefreshSearchTypeButton()
	{
		if (KuroSdkController.Instance.SupportSwitchFriendSearchByThirdPartyId())
		{
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
			string textStringId = "";
			if (this.CurrentSearchType == FriendSearchView.ECurrentSearchType.ThirdPartyId)
			{
				if (Info.Instance.IsPs5Platform())
				{
					textStringId = "PlayStationSearch";
				}
				else if (Info.Instance.IsXboxPlatform())
				{
					textStringId = "XboxSearch";
				}
			}
			else if (this.CurrentSearchType == FriendSearchView.ECurrentSearchType.Uid)
			{
				textStringId = "NormalSearch";
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), textStringId, Array.Empty<object>());
			return;
		}
		base.GetButton(6).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600AE00 RID: 44544 RVA: 0x00334BF0 File Offset: 0x00332DF0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.SearchPlayerInfo, new Action<int>(this.CallBackSearchPlayer));
		EventSystem.Instance.Add<int>(EEventName.ApplicationSent, new Action<int>(this.CallBackApplicationSent));
		EventSystem.Instance.Add<EFriendItemOperation, IReadOnlyList<int>>(EEventName.ApplicationHandled, new Action<EFriendItemOperation, IReadOnlyList<int>>(this.CallBackApplyPlayer));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshItemMuteState));
	}

	// Token: 0x0600AE01 RID: 44545 RVA: 0x00334C8C File Offset: 0x00332E8C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SearchPlayerInfo, new Action<int>(this.CallBackSearchPlayer));
		EventSystem.Instance.Remove(EEventName.ApplicationSent, new Action<int>(this.CallBackApplicationSent));
		EventSystem.Instance.Remove(EEventName.ApplicationHandled, new Action<EFriendItemOperation, IReadOnlyList<int>>(this.CallBackApplyPlayer));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshItemMuteState));
	}

	// Token: 0x0600AE02 RID: 44546 RVA: 0x00334D28 File Offset: 0x00332F28
	protected override UniTask OnBeforeStartAsync()
	{
		FriendSearchView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FriendSearchView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE03 RID: 44547 RVA: 0x00334D64 File Offset: 0x00332F64
	protected override void OnStart()
	{
		bool flag = !Info.Instance.IsHomeConsolePlatform();
		if (flag)
		{
			this.FunctionButtonItem = new ButtonAndSpriteItem(base.GetItem(1));
		}
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(3);
		this.ResultListLayout = new LoopScrollView<FriendItem, FriendItemSt>(base.GetLoopScrollViewComponent(4), item2.GetOwner() as AUIBaseActor, new Func<FriendItem>(this.CreateResultItem), true);
		base.GetInputText(0).OnTextChange.Bind(new Action<string>(this.SetClearOrPaste));
		FriendModel instance = FriendModel.Instance;
		instance.ClearFriendSearchResults();
		this.ResultList = FriendController.Instance.CreateFriendItemSt(instance.GetFriendSearchResultListIds(), EFriendItemOperation.Default);
		this.RefreshShow();
	}

	// Token: 0x0600AE04 RID: 44548 RVA: 0x00334E1F File Offset: 0x0033301F
	protected override void OnAfterHide()
	{
		FriendModel instance = FriendModel.Instance;
		instance.ClearApplyFriendList();
		instance.ClearApproveFriendList();
		instance.ClearRefuseFriendList();
	}

	// Token: 0x0600AE05 RID: 44549 RVA: 0x00334E37 File Offset: 0x00333037
	protected override void OnBeforeDestroy()
	{
		base.GetInputText(0).OnTextChange.Unbind();
		FriendModel.Instance.ResetShowingView();
	}

	// Token: 0x0600AE06 RID: 44550 RVA: 0x00334E54 File Offset: 0x00333054
	private FriendItem CreateResultItem()
	{
		return new FriendItem(this.ViewInfo.Name, null);
	}

	// Token: 0x0600AE07 RID: 44551 RVA: 0x00334E68 File Offset: 0x00333068
	private void RefreshShow()
	{
		if (this.ResultList.Count > 0)
		{
			this.ResultListLayout.RefreshByData(this.ResultList, false, null, false);
		}
		this.RefreshUiComponents();
		this.RefreshSearchTypeButton();
		this.RefreshPlaceHolderText();
		this.RefreshSearchColor();
		this.RefreshDescText();
	}

	// Token: 0x0600AE08 RID: 44552 RVA: 0x00334EB8 File Offset: 0x003330B8
	private void RefreshUiComponents()
	{
		base.GetInputText(0).SetText("", false);
		this.SetClearOrPaste("");
		base.GetItem(5).SetUIActive(this.ResultList.Count <= 0);
		base.GetLoopScrollViewComponent(4).RootUIComp.Get().SetUIActive(this.ResultList.Count > 0);
	}

	// Token: 0x0600AE09 RID: 44553 RVA: 0x00334F28 File Offset: 0x00333128
	private void SetClearOrPaste(string text)
	{
		if (this.FunctionButtonItem == null)
		{
			return;
		}
		if (base.GetInputText(0).GetText() == "")
		{
			this.FunctionButtonItem.RefreshSprite("SP_Paste");
			this.FunctionButtonItem.BindCallback(new Action(this.OnClickPasteBtn));
			return;
		}
		this.FunctionButtonItem.RefreshSprite("SP_Clear");
		this.FunctionButtonItem.BindCallback(new Action(this.OnClickClearBtn));
	}

	// Token: 0x0600AE0A RID: 44554 RVA: 0x00334FA5 File Offset: 0x003331A5
	private void OnClickClearBtn()
	{
		base.GetInputText(0).SetText("", false);
		this.SetClearOrPaste("");
	}

	// Token: 0x0600AE0B RID: 44555 RVA: 0x00334FC4 File Offset: 0x003331C4
	private void OnClickPasteBtn()
	{
		string pasteTarget = "";
		if (Platform.Instance.IsCloudGame())
		{
			UUITextInputComponent inputText = base.GetInputText(0);
			UKuroCloudGameWrapper.ClipBoardPaste();
			TimerSystem.GameplayTimeInstance.Delay(delegate(float delta)
			{
				ULGUIBPLibrary.ClipBoardPaste(ref pasteTarget);
				if (pasteTarget != "")
				{
					inputText.SetText(pasteTarget, false);
					this.SetClearOrPaste("");
				}
			}, 200f, null, null, true, 1f);
			return;
		}
		UUITextInputComponent inputText2 = base.GetInputText(0);
		ULGUIBPLibrary.ClipBoardPaste(ref pasteTarget);
		if (pasteTarget != "")
		{
			inputText2.SetText(pasteTarget, false);
			this.SetClearOrPaste("");
		}
	}

	// Token: 0x0600AE0C RID: 44556 RVA: 0x0033506C File Offset: 0x0033326C
	private void OnClickSearchConfirmBtn()
	{
		FriendModel instance = FriendModel.Instance;
		instance.ClearApplyFriendList();
		instance.ClearApproveFriendList();
		instance.ClearRefuseFriendList();
		string text = base.GetInputText(0).GetText();
		if (text.Length > 0)
		{
			if (this.CurrentSearchType == FriendSearchView.ECurrentSearchType.Uid)
			{
				int playerId = 0;
				if (int.TryParse(text, out playerId))
				{
					FriendController.Instance.RequestSearchPlayerBasicInfo(playerId, false);
					return;
				}
				GenericPromptController.Instance.ShowPromptByCode("InvalidUserId", Array.Empty<object>());
				return;
			}
			else
			{
				FriendController.Instance.RequestSearchPlayerBasicInfoBySdkId(text);
			}
		}
	}

	// Token: 0x0600AE0D RID: 44557 RVA: 0x003350E6 File Offset: 0x003332E6
	private void CallBackSearchPlayer(int playerId)
	{
		this.ResultList = FriendController.Instance.CreateFriendItemSt(new List<int>
		{
			playerId
		}, EFriendItemOperation.Default);
		this.RefreshShow();
	}

	// Token: 0x0600AE0E RID: 44558 RVA: 0x0033510B File Offset: 0x0033330B
	private void CallBackApplicationSent(int playerId)
	{
		this.ResultList = FriendController.Instance.CreateFriendItemSt(new List<int>
		{
			playerId
		}, EFriendItemOperation.SendApply);
		this.RefreshShow();
	}

	// Token: 0x0600AE0F RID: 44559 RVA: 0x00335130 File Offset: 0x00333330
	private void CallBackApplyPlayer(EFriendItemOperation operation, IReadOnlyList<int> ids)
	{
		this.ResultList = FriendController.Instance.CreateFriendItemSt(ids, operation);
		this.RefreshShow();
	}

	// Token: 0x0600AE10 RID: 44560 RVA: 0x0033514C File Offset: 0x0033334C
	private void RefreshItemMuteState(int playerId)
	{
		int i = 0;
		while (i < this.ResultList.Count)
		{
			if (this.ResultList[i].Id == playerId)
			{
				FriendItem friendItem = this.ResultListLayout.UnsafeGetGridProxy(i, false);
				if (friendItem == null)
				{
					return;
				}
				friendItem.RefreshMute();
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x04006412 RID: 25618
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FriendItem, FriendItemSt> ResultListLayout;

	// Token: 0x04006413 RID: 25619
	private List<FriendItemSt> ResultList = new List<FriendItemSt>();

	// Token: 0x04006414 RID: 25620
	private FriendSearchView.ECurrentSearchType CurrentSearchType;

	// Token: 0x04006415 RID: 25621
	[Nullable(2)]
	private ButtonAndSpriteItem FunctionButtonItem;

	// Token: 0x0200738D RID: 29581
	[NullableContext(0)]
	private enum ECurrentSearchType
	{
		// Token: 0x04025A13 RID: 154131
		Uid,
		// Token: 0x04025A14 RID: 154132
		ThirdPartyId
	}

	// Token: 0x0200738E RID: 29582
	[NullableContext(0)]
	private class EFriendSearchView
	{
		// Token: 0x04025A15 RID: 154133
		public const int SearchUIDTextInput = 0;

		// Token: 0x04025A16 RID: 154134
		public const int FunctionButtonItem = 1;

		// Token: 0x04025A17 RID: 154135
		public const int SearchConfirmBtn = 2;

		// Token: 0x04025A18 RID: 154136
		public const int ResultModelItem = 3;

		// Token: 0x04025A19 RID: 154137
		public const int ResultListLoopScrollView = 4;

		// Token: 0x04025A1A RID: 154138
		public const int ResultEmptyBox = 5;

		// Token: 0x04025A1B RID: 154139
		public const int SearchTypeButton = 6;

		// Token: 0x04025A1C RID: 154140
		public const int SearchTypeText = 7;

		// Token: 0x04025A1D RID: 154141
		public const int PlaceHolderText = 8;

		// Token: 0x04025A1E RID: 154142
		public const int DescText = 9;

		// Token: 0x04025A1F RID: 154143
		public const int NorSprite = 10;

		// Token: 0x04025A20 RID: 154144
		public const int HightSprite = 11;
	}
}
