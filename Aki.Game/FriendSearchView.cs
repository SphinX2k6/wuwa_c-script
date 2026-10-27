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

// Token: 0x02001C3F RID: 7231
[NullableContext(1)]
[Nullable(0)]
public class FriendSearchView : UiViewBase
{
	// Token: 0x0600D9E3 RID: 55779 RVA: 0x0032933D File Offset: 0x0032753D
	public FriendSearchView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D9E4 RID: 55780 RVA: 0x00329354 File Offset: 0x00327554
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

	// Token: 0x0600D9E5 RID: 55781 RVA: 0x0032956B File Offset: 0x0032776B
	private void OnClickSearchTypeButton()
	{
		this.CurrentSearchType = ((this.CurrentSearchType == FriendSearchView.ECurrentSearchType.Uid) ? FriendSearchView.ECurrentSearchType.ThirdPartyId : FriendSearchView.ECurrentSearchType.Uid);
		this.RefreshSearchTypeButton();
		this.RefreshPlaceHolderText();
		this.RefreshSearchColor();
		this.RefreshDescText();
	}

	// Token: 0x0600D9E6 RID: 55782 RVA: 0x00329598 File Offset: 0x00327798
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

	// Token: 0x0600D9E7 RID: 55783 RVA: 0x0032961C File Offset: 0x0032781C
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

	// Token: 0x0600D9E8 RID: 55784 RVA: 0x003296B0 File Offset: 0x003278B0
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

	// Token: 0x0600D9E9 RID: 55785 RVA: 0x00329744 File Offset: 0x00327944
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

	// Token: 0x0600D9EA RID: 55786 RVA: 0x003297F0 File Offset: 0x003279F0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.SearchPlayerInfo, new Action<int>(this.CallBackSearchPlayer));
		EventSystem.Instance.Add<int>(EEventName.ApplicationSent, new Action<int>(this.CallBackApplicationSent));
		EventSystem.Instance.Add<EFriendItemOperation, IReadOnlyList<int>>(EEventName.ApplicationHandled, new Action<EFriendItemOperation, IReadOnlyList<int>>(this.CallBackApplyPlayer));
		EventSystem.Instance.Add<int>(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshItemMuteState));
	}

	// Token: 0x0600D9EB RID: 55787 RVA: 0x0032988C File Offset: 0x00327A8C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.SearchPlayerInfo, new Action<int>(this.CallBackSearchPlayer));
		EventSystem.Instance.Remove(EEventName.ApplicationSent, new Action<int>(this.CallBackApplicationSent));
		EventSystem.Instance.Remove(EEventName.ApplicationHandled, new Action<EFriendItemOperation, IReadOnlyList<int>>(this.CallBackApplyPlayer));
		EventSystem.Instance.Remove(EEventName.OnAddMutePlayer, new Action<int>(this.RefreshItemMuteState));
		EventSystem.Instance.Remove(EEventName.OnRemoveMutePlayer, new Action<int>(this.RefreshItemMuteState));
	}

	// Token: 0x0600D9EC RID: 55788 RVA: 0x00329928 File Offset: 0x00327B28
	protected override UniTask OnBeforeStartAsync()
	{
		FriendSearchView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FriendSearchView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D9ED RID: 55789 RVA: 0x00329964 File Offset: 0x00327B64
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

	// Token: 0x0600D9EE RID: 55790 RVA: 0x00329A1F File Offset: 0x00327C1F
	protected override void OnAfterHide()
	{
		FriendModel instance = FriendModel.Instance;
		instance.ClearApplyFriendList();
		instance.ClearApproveFriendList();
		instance.ClearRefuseFriendList();
	}

	// Token: 0x0600D9EF RID: 55791 RVA: 0x00329A37 File Offset: 0x00327C37
	protected override void OnBeforeDestroy()
	{
		base.GetInputText(0).OnTextChange.Unbind();
		FriendModel.Instance.ResetShowingView();
	}

	// Token: 0x0600D9F0 RID: 55792 RVA: 0x00329A54 File Offset: 0x00327C54
	private FriendItem CreateResultItem()
	{
		return new FriendItem(this.ViewInfo.Name, null);
	}

	// Token: 0x0600D9F1 RID: 55793 RVA: 0x00329A68 File Offset: 0x00327C68
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

	// Token: 0x0600D9F2 RID: 55794 RVA: 0x00329AB8 File Offset: 0x00327CB8
	private void RefreshUiComponents()
	{
		base.GetInputText(0).SetText("", false);
		this.SetClearOrPaste("");
		base.GetItem(5).SetUIActive(this.ResultList.Count <= 0);
		base.GetLoopScrollViewComponent(4).RootUIComp.Get().SetUIActive(this.ResultList.Count > 0);
	}

	// Token: 0x0600D9F3 RID: 55795 RVA: 0x00329B28 File Offset: 0x00327D28
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

	// Token: 0x0600D9F4 RID: 55796 RVA: 0x00329BA5 File Offset: 0x00327DA5
	private void OnClickClearBtn()
	{
		base.GetInputText(0).SetText("", false);
		this.SetClearOrPaste("");
	}

	// Token: 0x0600D9F5 RID: 55797 RVA: 0x00329BC4 File Offset: 0x00327DC4
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

	// Token: 0x0600D9F6 RID: 55798 RVA: 0x00329C6C File Offset: 0x00327E6C
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

	// Token: 0x0600D9F7 RID: 55799 RVA: 0x00329CE6 File Offset: 0x00327EE6
	private void CallBackSearchPlayer(int playerId)
	{
		this.ResultList = FriendController.Instance.CreateFriendItemSt(new List<int>
		{
			playerId
		}, EFriendItemOperation.Default);
		this.RefreshShow();
	}

	// Token: 0x0600D9F8 RID: 55800 RVA: 0x00329D0B File Offset: 0x00327F0B
	private void CallBackApplicationSent(int playerId)
	{
		this.ResultList = FriendController.Instance.CreateFriendItemSt(new List<int>
		{
			playerId
		}, EFriendItemOperation.SendApply);
		this.RefreshShow();
	}

	// Token: 0x0600D9F9 RID: 55801 RVA: 0x00329D30 File Offset: 0x00327F30
	private void CallBackApplyPlayer(EFriendItemOperation operation, IReadOnlyList<int> ids)
	{
		this.ResultList = FriendController.Instance.CreateFriendItemSt(ids, operation);
		this.RefreshShow();
	}

	// Token: 0x0600D9FA RID: 55802 RVA: 0x00329D4C File Offset: 0x00327F4C
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

	// Token: 0x04006340 RID: 25408
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FriendItem, FriendItemSt> ResultListLayout;

	// Token: 0x04006341 RID: 25409
	private List<FriendItemSt> ResultList = new List<FriendItemSt>();

	// Token: 0x04006342 RID: 25410
	private FriendSearchView.ECurrentSearchType CurrentSearchType;

	// Token: 0x04006343 RID: 25411
	[Nullable(2)]
	private ButtonAndSpriteItem FunctionButtonItem;

	// Token: 0x02008204 RID: 33284
	[NullableContext(0)]
	private enum ECurrentSearchType
	{
		// Token: 0x0402A6EC RID: 173804
		Uid,
		// Token: 0x0402A6ED RID: 173805
		ThirdPartyId
	}

	// Token: 0x02008205 RID: 33285
	[NullableContext(0)]
	private class EFriendSearchView
	{
		// Token: 0x0402A6EE RID: 173806
		public const int SearchUIDTextInput = 0;

		// Token: 0x0402A6EF RID: 173807
		public const int FunctionButtonItem = 1;

		// Token: 0x0402A6F0 RID: 173808
		public const int SearchConfirmBtn = 2;

		// Token: 0x0402A6F1 RID: 173809
		public const int ResultModelItem = 3;

		// Token: 0x0402A6F2 RID: 173810
		public const int ResultListLoopScrollView = 4;

		// Token: 0x0402A6F3 RID: 173811
		public const int ResultEmptyBox = 5;

		// Token: 0x0402A6F4 RID: 173812
		public const int SearchTypeButton = 6;

		// Token: 0x0402A6F5 RID: 173813
		public const int SearchTypeText = 7;

		// Token: 0x0402A6F6 RID: 173814
		public const int PlaceHolderText = 8;

		// Token: 0x0402A6F7 RID: 173815
		public const int DescText = 9;

		// Token: 0x0402A6F8 RID: 173816
		public const int NorSprite = 10;

		// Token: 0x0402A6F9 RID: 173817
		public const int HightSprite = 11;
	}
}
