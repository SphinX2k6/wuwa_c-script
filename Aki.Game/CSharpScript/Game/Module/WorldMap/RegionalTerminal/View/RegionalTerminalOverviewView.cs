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
	// Token: 0x02004859 RID: 18521
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalOverviewView : UiViewBase
	{
		// Token: 0x0603077E RID: 198526 RVA: 0x00B4103C File Offset: 0x00B3F23C
		public RegionalTerminalOverviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603077F RID: 198527 RVA: 0x00B41068 File Offset: 0x00B3F268
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

		// Token: 0x06030780 RID: 198528 RVA: 0x00B41244 File Offset: 0x00B3F444
		protected override UniTask OnBeforeStartAsync()
		{
			RegionalTerminalOverviewView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RegionalTerminalOverviewView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030781 RID: 198529 RVA: 0x00B41288 File Offset: 0x00B3F488
		protected override void OnBeforeShow()
		{
			foreach (RegionalTerminalGroupItem regionalTerminalGroupItem in this.AreaScrollView.GetScrollItemList())
			{
				regionalTerminalGroupItem.RefreshFunctional();
			}
			this.RefreshSelectGameplayData();
		}

		// Token: 0x06030782 RID: 198530 RVA: 0x00B412E4 File Offset: 0x00B3F4E4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.RegionalTerminalGameplayPinUpdate, new Action<int, bool>(this.OnGameplayPinUpdate));
			EventSystem.Instance.Add(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnPlaySequenceEventByStringParam));
		}

		// Token: 0x06030783 RID: 198531 RVA: 0x00B4131E File Offset: 0x00B3F51E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RegionalTerminalGameplayPinUpdate, new Action<int, bool>(this.OnGameplayPinUpdate));
			EventSystem.Instance.Remove(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnPlaySequenceEventByStringParam));
		}

		// Token: 0x06030784 RID: 198532 RVA: 0x00B41358 File Offset: 0x00B3F558
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06030785 RID: 198533 RVA: 0x00B41360 File Offset: 0x00B3F560
		private UniTask InitGroupList()
		{
			RegionalTerminalOverviewView.<InitGroupList>d__19 <InitGroupList>d__;
			<InitGroupList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGroupList>d__.<>4__this = this;
			<InitGroupList>d__.<>1__state = -1;
			<InitGroupList>d__.<>t__builder.Start<RegionalTerminalOverviewView.<InitGroupList>d__19>(ref <InitGroupList>d__);
			return <InitGroupList>d__.<>t__builder.Task;
		}

		// Token: 0x06030786 RID: 198534 RVA: 0x00B413A4 File Offset: 0x00B3F5A4
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

		// Token: 0x06030787 RID: 198535 RVA: 0x00B41401 File Offset: 0x00B3F601
		private int SortGroupData(RegionalTerminalGroupData a, RegionalTerminalGroupData b)
		{
			return b.SortId - a.SortId;
		}

		// Token: 0x06030788 RID: 198536 RVA: 0x00B41410 File Offset: 0x00B3F610
		private RegionalTerminalGroupItem CreateGroupItem()
		{
			return new RegionalTerminalGroupItem
			{
				OnClickToggleCallBack = new Action<bool, RegionalTerminalGameplayData, int>(this.OnClickGameplayItemToggle),
				IsToggleSelectOnCallBack = new Func<RegionalTerminalGameplayData, bool>(this.IsGameplayItemToggleSelectOn)
			};
		}

		// Token: 0x06030789 RID: 198537 RVA: 0x00B4143C File Offset: 0x00B3F63C
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

		// Token: 0x0603078A RID: 198538 RVA: 0x00B414B4 File Offset: 0x00B3F6B4
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

		// Token: 0x0603078B RID: 198539 RVA: 0x00B414ED File Offset: 0x00B3F6ED
		private bool IsGameplayItemToggleSelectOn(RegionalTerminalGameplayData data)
		{
			return this.CurrentSelectGameplayData == data;
		}

		// Token: 0x0603078C RID: 198540 RVA: 0x00B414F8 File Offset: 0x00B3F6F8
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

		// Token: 0x0603078D RID: 198541 RVA: 0x00B41540 File Offset: 0x00B3F740
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

		// Token: 0x0603078E RID: 198542 RVA: 0x00B4157C File Offset: 0x00B3F77C
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

		// Token: 0x0603078F RID: 198543 RVA: 0x00B415B3 File Offset: 0x00B3F7B3
		private void InitPinToggle()
		{
			base.GetExtendToggle(7).CanExecuteChange.Bind(new Func<bool>(this.CanExecutePinToggle));
		}

		// Token: 0x06030790 RID: 198544 RVA: 0x00B415D4 File Offset: 0x00B3F7D4
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

		// Token: 0x06030791 RID: 198545 RVA: 0x00B4168C File Offset: 0x00B3F88C
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

		// Token: 0x06030792 RID: 198546 RVA: 0x00B416F8 File Offset: 0x00B3F8F8
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

		// Token: 0x06030793 RID: 198547 RVA: 0x00B41868 File Offset: 0x00B3FA68
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

		// Token: 0x06030794 RID: 198548 RVA: 0x00B418D0 File Offset: 0x00B3FAD0
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

		// Token: 0x06030795 RID: 198549 RVA: 0x00B41964 File Offset: 0x00B3FB64
		private void RefreshGameplayItem(RegionalTerminalGameplayData data)
		{
			this.GameplayItem.RefreshAsync(data, false, 0);
		}

		// Token: 0x06030796 RID: 198550 RVA: 0x00B41978 File Offset: 0x00B3FB78
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

		// Token: 0x06030797 RID: 198551 RVA: 0x00B419E0 File Offset: 0x00B3FBE0
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

		// Token: 0x06030798 RID: 198552 RVA: 0x00B41A55 File Offset: 0x00B3FC55
		private void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				this.ButtonItem.UnBindGivenUid(this.RedDotId);
				this.RedDotId = 0;
				this.RedDotName = null;
			}
		}

		// Token: 0x0401A0A9 RID: 106665
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401A0AA RID: 106666
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RegionalTerminalGroupItem, RegionalTerminalGroupData> AreaScrollView;

		// Token: 0x0401A0AB RID: 106667
		[Nullable(2)]
		private RegionalTerminalGameplayItem GameplayItem;

		// Token: 0x0401A0AC RID: 106668
		[Nullable(2)]
		private FunctionalPanelConditionLock PanelLock;

		// Token: 0x0401A0AD RID: 106669
		[Nullable(2)]
		private ButtonItem ButtonItem;

		// Token: 0x0401A0AE RID: 106670
		private ERedDotName? RedDotName;

		// Token: 0x0401A0AF RID: 106671
		private int RedDotId;

		// Token: 0x0401A0B0 RID: 106672
		[Nullable(2)]
		private RegionalTerminalGameplayData CurrentSelectGameplayData;

		// Token: 0x0401A0B1 RID: 106673
		private readonly int PinMaxCount = ConfigCommonParamById.GetIntConfig("AreaTerminalPinMaxCount").GetValueOrDefault();

		// Token: 0x0401A0B2 RID: 106674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0200AB40 RID: 43840
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x040340AB RID: 213163
			public const int CaptionItem = 0;

			// Token: 0x040340AC RID: 213164
			public const int GroupScrollView = 1;

			// Token: 0x040340AD RID: 213165
			public const int GroupItem = 2;

			// Token: 0x040340AE RID: 213166
			public const int RightGameplayItem = 3;

			// Token: 0x040340AF RID: 213167
			public const int TxtDesc = 4;

			// Token: 0x040340B0 RID: 213168
			public const int PinPanel = 5;

			// Token: 0x040340B1 RID: 213169
			public const int TxtPin = 6;

			// Token: 0x040340B2 RID: 213170
			public const int TogglePin = 7;

			// Token: 0x040340B3 RID: 213171
			public const int PanelLock = 8;

			// Token: 0x040340B4 RID: 213172
			public const int BtnConfirm = 9;

			// Token: 0x040340B5 RID: 213173
			public const int RewardPanel = 10;

			// Token: 0x040340B6 RID: 213174
			public const int RewardScroll = 11;

			// Token: 0x040340B7 RID: 213175
			public const int RewardItem = 12;
		}

		// Token: 0x0200AB41 RID: 43841
		[Nullable(0)]
		public static class ESequenceName
		{
			// Token: 0x040340B8 RID: 213176
			public const string Start = "Start";

			// Token: 0x040340B9 RID: 213177
			public const string Switch = "Switch";
		}
	}
}
