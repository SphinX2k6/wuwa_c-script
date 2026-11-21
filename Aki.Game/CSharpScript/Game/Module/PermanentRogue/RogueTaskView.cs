using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004318 RID: 17176
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueTaskView : UiViewBase
	{
		// Token: 0x0602B673 RID: 177779 RVA: 0x00C33622 File Offset: 0x00C31822
		public RogueTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B674 RID: 177780 RVA: 0x00C33660 File Offset: 0x00C31860
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.OnClickBtnRogue))
			};
		}

		// Token: 0x0602B675 RID: 177781 RVA: 0x00C33790 File Offset: 0x00C31990
		protected override void OnStart()
		{
			this.RemainTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			this.RefreshTimeTitle();
			this.TabLayout = new GenericLayout<RogueTaskTabItem, RogueTaskRewardTabData>(base.GetHorizontalLayout(1), new Func<RogueTaskTabItem>(this.TabItemProxyCreate), null, false, true);
			this.ScrollView = new GenericScrollViewNew<RogueTaskItem, RogueTaskData>(base.GetScrollViewWithScrollbar(3), new Func<RogueTaskItem>(this.InitTaskItem), null, false, null);
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBackBtn));
			this.CaptionItem.SetHelpBtnActive(false);
		}

		// Token: 0x0602B676 RID: 177782 RVA: 0x00C3382B File Offset: 0x00C31A2B
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.ScrollView = null;
			this.TabLayout = null;
		}

		// Token: 0x0602B677 RID: 177783 RVA: 0x00C33844 File Offset: 0x00C31A44
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			RogueTaskView.<OnBeforeShowAsyncImplement>d__15 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RogueTaskView.<OnBeforeShowAsyncImplement>d__15>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602B678 RID: 177784 RVA: 0x00C33887 File Offset: 0x00C31A87
		protected override void OnBeforeShow()
		{
			this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
			this.OnTimerRefresh(0f);
		}

		// Token: 0x0602B679 RID: 177785 RVA: 0x00C338C3 File Offset: 0x00C31AC3
		protected override void OnAfterHide()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x0602B67A RID: 177786 RVA: 0x00C338EF File Offset: 0x00C31AEF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(this.OnGetRewardUpdate));
		}

		// Token: 0x0602B67B RID: 177787 RVA: 0x00C3390D File Offset: 0x00C31B0D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(this.OnGetRewardUpdate));
		}

		// Token: 0x0602B67C RID: 177788 RVA: 0x00C3392C File Offset: 0x00C31B2C
		private UniTask InitRolePortrait()
		{
			RogueTaskView.<InitRolePortrait>d__20 <InitRolePortrait>d__;
			<InitRolePortrait>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRolePortrait>d__.<>4__this = this;
			<InitRolePortrait>d__.<>1__state = -1;
			<InitRolePortrait>d__.<>t__builder.Start<RogueTaskView.<InitRolePortrait>d__20>(ref <InitRolePortrait>d__);
			return <InitRolePortrait>d__.<>t__builder.Task;
		}

		// Token: 0x0602B67D RID: 177789 RVA: 0x00C3396F File Offset: 0x00C31B6F
		private RogueTaskTabItem TabItemProxyCreate()
		{
			return new RogueTaskTabItem();
		}

		// Token: 0x0602B67E RID: 177790 RVA: 0x00C33976 File Offset: 0x00C31B76
		private RogueTaskItem InitTaskItem()
		{
			return new RogueTaskItem();
		}

		// Token: 0x0602B67F RID: 177791 RVA: 0x00C33980 File Offset: 0x00C31B80
		private void OnClickTab(int index)
		{
			if (index == 4 && !ActivityPermanentRogueModel.Instance.GetActivityData().SaveFirstCheckRedDotState(EPermanentRogueSaveFlag.NewTaskCheck))
			{
				EventSystem.Instance.Emit(EEventName.PermanentRogueRewardUpdate);
				this.TabLayout.GetLayoutItemByIndex(this.TabTypeList.IndexOf(index)).RefreshRedDot();
			}
			for (int i = 0; i < this.TabTypeList.Count; i++)
			{
				this.TabLayout.GetLayoutItemByIndex(i).SetToggleState(index == this.TabTypeList[i], false);
			}
			this.CurrentTypeIndex = index;
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x0602B680 RID: 177792 RVA: 0x00C33A19 File Offset: 0x00C31C19
		private void OnGetRewardUpdate()
		{
			this.TabLayout.GetLayoutItemByIndex(this.TabTypeList.IndexOf(this.CurrentTypeIndex)).RefreshRedDot();
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x0602B681 RID: 177793 RVA: 0x00C33A48 File Offset: 0x00C31C48
		private void OnClickBtnRogue()
		{
			int newSeasonId = ActivityPermanentRogueModel.Instance.GetNewSeasonId();
			base.CloseMe(null);
			if (UiManager.Instance.IsViewOpen(EUiViewName.RogueSeasonEntranceView))
			{
				UiManager.Instance.NormalResetToView(EUiViewName.RogueSeasonEntranceView, null, true);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RogueSeasonEntranceView, newSeasonId, null);
		}

		// Token: 0x0602B682 RID: 177794 RVA: 0x00C33AA0 File Offset: 0x00C31CA0
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602B683 RID: 177795 RVA: 0x00C33AA9 File Offset: 0x00C31CA9
		private void OnTimerRefresh(float delta)
		{
			this.RefreshTimeTitle();
		}

		// Token: 0x0602B684 RID: 177796 RVA: 0x00C33AB4 File Offset: 0x00C31CB4
		private List<RogueTaskRewardTabData> CreateTabItemDataList()
		{
			ActivityPermanentRogueData activityData = ActivityPermanentRogueModel.Instance.GetActivityData();
			RogueResTaskTheme? config = ConfigRogueResTaskThemeById.GetConfig(activityData.GetTaskThemeId(), true);
			List<RogueTaskRewardTabData> list = new List<RogueTaskRewardTabData>();
			this.TabTypeList.Clear();
			foreach (DicIntString dicIntString in config.Value.TabNamesIter())
			{
				if (activityData.GetTaskListByType(dicIntString.Key).Count != 0)
				{
					RogueTaskRewardTabData rogueTaskRewardTabData = new RogueTaskRewardTabData();
					rogueTaskRewardTabData.NameTextId = dicIntString.Value;
					rogueTaskRewardTabData.Index = dicIntString.Key;
					rogueTaskRewardTabData.ClickedCallback = new Action<int>(this.OnClickTab);
					rogueTaskRewardTabData.RefreshRedDot = ((int tabIndex) => ActivityPermanentRogueModel.Instance.CheckTaskRedDot(tabIndex));
					list.Add(rogueTaskRewardTabData);
					this.TabTypeList.Add(rogueTaskRewardTabData.Index);
				}
			}
			this.CurrentTypeIndex = ((this.TabTypeList.Count > 0) ? this.TabTypeList[0] : -1);
			return list;
		}

		// Token: 0x0602B685 RID: 177797 RVA: 0x00C33BE4 File Offset: 0x00C31DE4
		private void RefreshScrollView(int tabIndex)
		{
			this.DataList.Clear();
			List<RogueTaskData> taskDataListById = ActivityPermanentRogueModel.Instance.GetTaskDataListById(tabIndex);
			taskDataListById.Sort(new Comparison<RogueTaskData>(ActivityPermanentRogueModel.Instance.SortTaskData));
			this.DataList = taskDataListById;
			this.ScrollView.RefreshByDataAsync(this.DataList, true);
			int taskProgressByType = ActivityPermanentRogueModel.Instance.GetTaskProgressByType(this.TabTypeList[tabIndex - 1]);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RogueRes_Task_Progress", new <>z__ReadOnlySingleElementList<object>(taskProgressByType));
		}

		// Token: 0x0602B686 RID: 177798 RVA: 0x00C33C74 File Offset: 0x00C31E74
		private void RefreshTimeTitle()
		{
			long endTime = MathUtils.Instance.LongToNumber(ActivityPermanentRogueModel.Instance.GetTaskEndTime());
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(endTime, this.RemainTimeText);
			UUIText text = base.GetText(10);
			if (text != null)
			{
				text.SetUIActive(remainTimeText != null);
			}
			if (text != null)
			{
				text.SetText(remainTimeText ?? "0", true);
			}
			if (ActivityPermanentRogueModel.Instance.GetTaskIsEnd() && !this.TimeoutConfirm)
			{
				this.TimeoutConfirm = true;
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
				confirmBoxDataNew.FunctionMap.Add(1, new Action(RogueTaskView.<RefreshTimeTitle>g__confirmCallback|30_0));
				confirmBoxDataNew.FunctionMap.Add(0, new Action(RogueTaskView.<RefreshTimeTitle>g__confirmCallback|30_0));
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
		}

		// Token: 0x0602B687 RID: 177799 RVA: 0x00C33D35 File Offset: 0x00C31F35
		[CompilerGenerated]
		internal static void <RefreshTimeTitle>g__confirmCallback|30_0()
		{
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x0401774D RID: 96077
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RogueTaskTabItem, RogueTaskRewardTabData> TabLayout;

		// Token: 0x0401774E RID: 96078
		protected int CurrentTypeIndex = 1;

		// Token: 0x0401774F RID: 96079
		protected List<int> TabTypeList = new List<int>();

		// Token: 0x04017750 RID: 96080
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<RogueTaskItem, RogueTaskData> ScrollView;

		// Token: 0x04017751 RID: 96081
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017752 RID: 96082
		private List<RogueTaskData> DataList = new List<RogueTaskData>();

		// Token: 0x04017753 RID: 96083
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x04017754 RID: 96084
		private string RemainTimeText = "";

		// Token: 0x04017755 RID: 96085
		private readonly List<RogueTaskRoleItem> RoleItemList = new List<RogueTaskRoleItem>();

		// Token: 0x04017756 RID: 96086
		private bool TimeoutConfirm;

		// Token: 0x04017757 RID: 96087
		private const int MAX_ROLE_COUNT = 3;
	}
}
