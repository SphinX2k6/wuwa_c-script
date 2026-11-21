using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.View
{
	// Token: 0x0200378A RID: 14218
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalOverviewView : UiViewBase
	{
		// Token: 0x06024F4D RID: 151373 RVA: 0x00A71280 File Offset: 0x00A6F480
		public RegionalTerminalOverviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06024F4E RID: 151374 RVA: 0x00A712AC File Offset: 0x00A6F4AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024F4F RID: 151375 RVA: 0x00A71488 File Offset: 0x00A6F688
		protected override UniTask OnBeforeStartAsync()
		{
			RegionalTerminalOverviewView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RegionalTerminalOverviewView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024F50 RID: 151376 RVA: 0x00A714CC File Offset: 0x00A6F6CC
		protected override void OnBeforeShow()
		{
			foreach (RegionalTerminalGroupItem regionalTerminalGroupItem in this.AreaScrollView.GetScrollItemList())
			{
				regionalTerminalGroupItem.RefreshFunctional();
			}
			this.RefreshSelectGameplayData();
		}

		// Token: 0x06024F51 RID: 151377 RVA: 0x00A71528 File Offset: 0x00A6F728
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.RegionalTerminalGameplayPinUpdate, new Action<int, bool>(this.OnGameplayPinUpdate));
			EventSystem.Instance.Add(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnPlaySequenceEventByStringParam));
		}

		// Token: 0x06024F52 RID: 151378 RVA: 0x00A71562 File Offset: 0x00A6F762
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RegionalTerminalGameplayPinUpdate, new Action<int, bool>(this.OnGameplayPinUpdate));
			EventSystem.Instance.Remove(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnPlaySequenceEventByStringParam));
		}

		// Token: 0x06024F53 RID: 151379 RVA: 0x00A7159C File Offset: 0x00A6F79C
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06024F54 RID: 151380 RVA: 0x00A715A4 File Offset: 0x00A6F7A4
		private UniTask InitGroupList()
		{
			RegionalTerminalOverviewView.<InitGroupList>d__19 <InitGroupList>d__;
			<InitGroupList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGroupList>d__.<>4__this = this;
			<InitGroupList>d__.<>1__state = -1;
			<InitGroupList>d__.<>t__builder.Start<RegionalTerminalOverviewView.<InitGroupList>d__19>(ref <InitGroupList>d__);
			return <InitGroupList>d__.<>t__builder.Task;
		}

		// Token: 0x06024F55 RID: 151381 RVA: 0x00A715E8 File Offset: 0x00A6F7E8
		private void InitScroll()
		{
			RegionalTerminalGroupItem scrollItemByKey = this.AreaScrollView.GetScrollItemByKey(this.CurrentSelectGameplayData.GroupId);
			UUIItem uuiitem;
			if (scrollItemByKey == null)
			{
				uuiitem = null;
			}
			else
			{
				RegionalTerminalGameplayItem gameplayItem = scrollItemByKey.GetGameplayItem(this.CurrentSelectGameplayData.Id);
				uuiitem = ((gameplayItem != null) ? gameplayItem.GetRootItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 != null)
			{
				this.AreaScrollView.LateScrollTo(uuiitem2, null, false);
			}
		}

		// Token: 0x06024F56 RID: 151382 RVA: 0x00A71645 File Offset: 0x00A6F845
		private int SortGroupData(RegionalTerminalGroupData a, RegionalTerminalGroupData b)
		{
			return b.SortId - a.SortId;
		}

		// Token: 0x06024F57 RID: 151383 RVA: 0x00A71654 File Offset: 0x00A6F854
		private RegionalTerminalGroupItem CreateGroupItem()
		{
			return new RegionalTerminalGroupItem
			{
				OnClickToggleCallBack = new Action<bool, RegionalTerminalGameplayData, int>(this.OnClickGameplayItemToggle),
				IsToggleSelectOnCallBack = new Func<RegionalTerminalGameplayData, bool>(this.IsGameplayItemToggleSelectOn)
			};
		}

		// Token: 0x06024F58 RID: 151384 RVA: 0x00A71680 File Offset: 0x00A6F880
		private void OnClickGameplayItemToggle(bool state, RegionalTerminalGameplayData data, int groupId)
		{
			if (!state)
			{
				return;
			}
			if (this.CurrentSelectGameplayData != null)
			{
				RegionalTerminalGroupItem scrollItemByKey = this.AreaScrollView.GetScrollItemByKey(this.CurrentSelectGameplayData.GroupId);
				if (groupId != this.CurrentSelectGameplayData.GroupId && scrollItemByKey != null)
				{
					scrollItemByKey.SetSelectOn(false);
				}
				if (scrollItemByKey != null)
				{
					RegionalTerminalGameplayItem gameplayItem = scrollItemByKey.GetGameplayItem(this.CurrentSelectGameplayData.Id);
					if (gameplayItem != null)
					{
						gameplayItem.OnDeselected(false);
					}
				}
			}
			this.SelectGameplayItem(data, groupId);
		}

		// Token: 0x06024F59 RID: 151385 RVA: 0x00A716F8 File Offset: 0x00A6F8F8
		private void SelectGameplayItem(RegionalTerminalGameplayData data, int groupId)
		{
			this.CurrentSelectGameplayData = data;
			this.RefreshSelectGameplayData();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06024F5A RID: 151386 RVA: 0x00A71731 File Offset: 0x00A6F931
		private bool IsGameplayItemToggleSelectOn(RegionalTerminalGameplayData data)
		{
			return this.CurrentSelectGameplayData == data;
		}

		// Token: 0x06024F5B RID: 151387 RVA: 0x00A7173C File Offset: 0x00A6F93C
		[NullableContext(2)]
		private RegionalTerminalGameplayItem GetGameplayItem(int gameplayId)
		{
			RegionalTerminalGameplayData valueOrDefault = RegionalTerminalModel.Instance.GameplayDataMap.GetValueOrDefault(gameplayId);
			if (valueOrDefault == null)
			{
				return null;
			}
			RegionalTerminalGroupItem scrollItemByKey = this.AreaScrollView.GetScrollItemByKey(valueOrDefault.GroupId);
			if (scrollItemByKey == null)
			{
				return null;
			}
			return scrollItemByKey.GetGameplayItem(gameplayId);
		}

		// Token: 0x06024F5C RID: 151388 RVA: 0x00A71784 File Offset: 0x00A6F984
		private void OnPlaySequenceEventByStringParam(string eventName)
		{
			GenericLayout<RegionalTerminalGroupItem, RegionalTerminalGroupData> genericLayout = this.AreaScrollView.GetGenericLayout();
			UUIInturnAnimController uuiinturnAnimController = (genericLayout != null) ? genericLayout.GetUiAnimController() : null;
			if (uuiinturnAnimController != null)
			{
				uuiinturnAnimController.AnimName = eventName;
				uuiinturnAnimController.Play("", -1, false);
			}
		}

		// Token: 0x06024F5D RID: 151389 RVA: 0x00A717C0 File Offset: 0x00A6F9C0
		private void OnGameplayPinUpdate(int gameplayId, bool isPin)
		{
			RegionalTerminalGameplayData currentSelectGameplayData = this.CurrentSelectGameplayData;
			if (currentSelectGameplayData != null && currentSelectGameplayData.Id == gameplayId)
			{
				this.RefreshGameplayItem(this.CurrentSelectGameplayData);
			}
			RegionalTerminalGameplayItem gameplayItem = this.GetGameplayItem(gameplayId);
			if (gameplayItem == null)
			{
				return;
			}
			gameplayItem.SetPin(isPin);
		}

		// Token: 0x06024F5E RID: 151390 RVA: 0x00A717F7 File Offset: 0x00A6F9F7
		private void InitPinToggle()
		{
			base.GetExtendToggle(7).CanExecuteChange.Bind(new Func<bool>(this.CanExecutePinToggle));
		}

		// Token: 0x06024F5F RID: 151391 RVA: 0x00A71818 File Offset: 0x00A6FA18
		private unsafe void OnClickTogglePin(bool isPin)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Map;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[RegionalTerminal] PinGameplay";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GameplayId", this.CurrentSelectGameplayData.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsPin", isPin);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			int id = this.CurrentSelectGameplayData.Id;
			RegionalTerminalController.Instance.RequestTerminalPinOperation(id, isPin, delegate(bool success)
			{
				RegionalTerminalModel.Instance.StartPinCdTimer();
				if (!success)
				{
					return;
				}
				this.RefreshPin(false);
				string textId = isPin ? "Terminal_Area_PinTipSuccess" : "Terminal_Area_PinTipCancel";
				ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
			});
		}

		// Token: 0x06024F60 RID: 151392 RVA: 0x00A718D0 File Offset: 0x00A6FAD0
		private bool CanExecutePinToggle()
		{
			if (this.CurrentSelectGameplayData == null)
			{
				return false;
			}
			EToggleState toggleState = base.GetExtendToggle(7).GetToggleState();
			if (toggleState == EToggleState.ETT_UnChecked && RegionalTerminalModel.Instance.GetPinnedGameplayIds().Count >= this.PinMaxCount)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Terminal_Area_PinTipMax", Array.Empty<object>());
				return false;
			}
			if (!RegionalTerminalModel.Instance.IsInPinCd)
			{
				this.OnClickTogglePin(toggleState == EToggleState.ETT_UnChecked);
			}
			return false;
		}

		// Token: 0x06024F61 RID: 151393 RVA: 0x00A7193C File Offset: 0x00A6FB3C
		private void RefreshSelectGameplayData()
		{
			if (this.CurrentSelectGameplayData == null)
			{
				return;
			}
			this.CurrentSelectGameplayData.OnSelected();
			this.RefreshGameplayItem(this.CurrentSelectGameplayData);
			RegionalTerminalGroupItem scrollItemByKey = this.AreaScrollView.GetScrollItemByKey(this.CurrentSelectGameplayData.GroupId);
			if (scrollItemByKey != null)
			{
				scrollItemByKey.SetSelectOn(true);
			}
			bool lockState = this.CurrentSelectGameplayData.GetLockState();
			AreaTerminal? areaTerminalByGameplayId = RegionalTerminalConfig.Instance.GetAreaTerminalByGameplayId(this.CurrentSelectGameplayData.Id);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), areaTerminalByGameplayId.Value.Desc, Array.Empty<object>());
			this.RefreshRewardPreview();
			this.RefreshPin(true);
			base.GetItem(5).SetUIActive(!lockState);
			IRegionalTerminalViewParams viewParams = this.CurrentSelectGameplayData.GetViewParams();
			this.PanelLock.SetUiActive(viewParams.ShowLockPanel);
			if (viewParams.ShowLockPanel)
			{
				if (viewParams.LockClickFunc != null)
				{
					this.PanelLock.ButtonCallBack = viewParams.LockClickFunc;
					this.PanelLock.SetButtonVisible(true);
				}
				else
				{
					this.PanelLock.SetButtonVisible(false);
				}
				if (!string.IsNullOrEmpty(viewParams.LockTxtId))
				{
					this.PanelLock.SetTextByTextId(viewParams.LockTxtId, Array.Empty<string>());
				}
			}
			if (!string.IsNullOrEmpty(viewParams.ButtonTxtId))
			{
				this.ButtonItem.SetLocalTextNew(viewParams.ButtonTxtId, Array.Empty<object>());
			}
			this.ButtonItem.SetUiActive(viewParams.ShowButton);
			this.BindRedDot();
		}

		// Token: 0x06024F62 RID: 151394 RVA: 0x00A71AAC File Offset: 0x00A6FCAC
		private void RefreshRewardPreview()
		{
			if (this.CurrentSelectGameplayData == null)
			{
				return;
			}
			List<TItem> rewardPreviewList = this.CurrentSelectGameplayData.GetRewardPreviewList();
			bool flag = rewardPreviewList != null && rewardPreviewList.Count > 0;
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
				if (rewardScrollView == null)
				{
					return;
				}
				rewardScrollView.RefreshByData(rewardPreviewList, delegate
				{
					UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(11);
					if (scrollViewWithScrollbar == null)
					{
						return;
					}
					scrollViewWithScrollbar.SetScrollProgress(1f);
				}, false);
			}
		}

		// Token: 0x06024F63 RID: 151395 RVA: 0x00A71B14 File Offset: 0x00A6FD14
		private void RefreshPin(bool bIngnoreAnim)
		{
			bool flag = RegionalTerminalModel.Instance.IsGameplayPin(this.CurrentSelectGameplayData.Id);
			base.GetExtendToggle(7).SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, bIngnoreAnim);
			if (!bIngnoreAnim)
			{
				AudioSystem.Instance.PostEvent("play_ui_ia_com_tab_click");
			}
			int count = RegionalTerminalModel.Instance.GetPinnedGameplayIds().Count;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Terminal_Area_PinText", new <>z__ReadOnlyArray<object>(new object[]
			{
				count,
				this.PinMaxCount
			}));
		}

		// Token: 0x06024F64 RID: 151396 RVA: 0x00A71BA8 File Offset: 0x00A6FDA8
		private void RefreshGameplayItem(RegionalTerminalGameplayData data)
		{
			this.GameplayItem.RefreshAsync(data, false, 0);
		}

		// Token: 0x06024F65 RID: 151397 RVA: 0x00A71BBC File Offset: 0x00A6FDBC
		private void OnClickButton(int index)
		{
			if (this.CurrentSelectGameplayData == null)
			{
				return;
			}
			RegionalTerminalGameplayData currentSelectGameplayData = this.CurrentSelectGameplayData;
			if (currentSelectGameplayData != null)
			{
				currentSelectGameplayData.TerminalFunction(null);
			}
			if (this.CurrentSelectGameplayData.CloseTerminalWhenForwarding)
			{
				base.CloseMe(null);
			}
			AreaTerminalOpenActivityLogEvent areaTerminalOpenActivityLogEvent = new AreaTerminalOpenActivityLogEvent();
			areaTerminalOpenActivityLogEvent.i_id = this.CurrentSelectGameplayData.Id;
			areaTerminalOpenActivityLogEvent.i_type = 2;
			LogReportController.Instance.LogReport(areaTerminalOpenActivityLogEvent);
		}

		// Token: 0x06024F66 RID: 151398 RVA: 0x00A71C24 File Offset: 0x00A6FE24
		private void BindRedDot()
		{
			this.UnBindRedDot();
			this.RedDotName = this.CurrentSelectGameplayData.GetRedDotName();
			this.RedDotId = this.CurrentSelectGameplayData.GetRedDotId();
			if (this.RedDotName != null)
			{
				this.ButtonItem.BindRedDot(this.RedDotName.Value, this.RedDotId);
				return;
			}
			this.ButtonItem.SetRedDotVisible(this.CurrentSelectGameplayData.GetRedDotState());
		}

		// Token: 0x06024F67 RID: 151399 RVA: 0x00A71C99 File Offset: 0x00A6FE99
		private void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				this.ButtonItem.UnBindGivenUid(this.RedDotId);
				this.RedDotId = 0;
				this.RedDotName = null;
			}
		}

		// Token: 0x0401475D RID: 83805
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401475E RID: 83806
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RegionalTerminalGroupItem, RegionalTerminalGroupData> AreaScrollView;

		// Token: 0x0401475F RID: 83807
		[Nullable(2)]
		private RegionalTerminalGameplayItem GameplayItem;

		// Token: 0x04014760 RID: 83808
		[Nullable(2)]
		private FunctionalPanelConditionLock PanelLock;

		// Token: 0x04014761 RID: 83809
		[Nullable(2)]
		private ButtonItem ButtonItem;

		// Token: 0x04014762 RID: 83810
		private ERedDotName? RedDotName;

		// Token: 0x04014763 RID: 83811
		private int RedDotId;

		// Token: 0x04014764 RID: 83812
		[Nullable(2)]
		private RegionalTerminalGameplayData CurrentSelectGameplayData;

		// Token: 0x04014765 RID: 83813
		private readonly int PinMaxCount = ConfigCommonParamById.GetIntConfig("AreaTerminalPinMaxCount").GetValueOrDefault();

		// Token: 0x04014766 RID: 83814
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x020094EE RID: 38126
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E823 RID: 190499
			public const int CaptionItem = 0;

			// Token: 0x0402E824 RID: 190500
			public const int GroupScrollView = 1;

			// Token: 0x0402E825 RID: 190501
			public const int GroupItem = 2;

			// Token: 0x0402E826 RID: 190502
			public const int RightGameplayItem = 3;

			// Token: 0x0402E827 RID: 190503
			public const int TxtDesc = 4;

			// Token: 0x0402E828 RID: 190504
			public const int PinPanel = 5;

			// Token: 0x0402E829 RID: 190505
			public const int TxtPin = 6;

			// Token: 0x0402E82A RID: 190506
			public const int TogglePin = 7;

			// Token: 0x0402E82B RID: 190507
			public const int PanelLock = 8;

			// Token: 0x0402E82C RID: 190508
			public const int BtnConfirm = 9;

			// Token: 0x0402E82D RID: 190509
			public const int RewardPanel = 10;

			// Token: 0x0402E82E RID: 190510
			public const int RewardScroll = 11;

			// Token: 0x0402E82F RID: 190511
			public const int RewardItem = 12;
		}

		// Token: 0x020094EF RID: 38127
		[Nullable(0)]
		public static class ESequenceName
		{
			// Token: 0x0402E830 RID: 190512
			public const string Start = "Start";

			// Token: 0x0402E831 RID: 190513
			public const string Switch = "Switch";
		}
	}
}
