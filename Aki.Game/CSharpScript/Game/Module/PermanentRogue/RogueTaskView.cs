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
	// Token: 0x02005348 RID: 21320
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueTaskView : UiViewBase
	{
		// Token: 0x06036777 RID: 223095 RVA: 0x00CE5C52 File Offset: 0x00CE3E52
		public RogueTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036778 RID: 223096 RVA: 0x00CE5C90 File Offset: 0x00CE3E90
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

		// Token: 0x06036779 RID: 223097 RVA: 0x00CE5DC0 File Offset: 0x00CE3FC0
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

		// Token: 0x0603677A RID: 223098 RVA: 0x00CE5E5B File Offset: 0x00CE405B
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.ScrollView = null;
			this.TabLayout = null;
		}

		// Token: 0x0603677B RID: 223099 RVA: 0x00CE5E74 File Offset: 0x00CE4074
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			RogueTaskView.<OnBeforeShowAsyncImplement>d__15 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RogueTaskView.<OnBeforeShowAsyncImplement>d__15>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603677C RID: 223100 RVA: 0x00CE5EB7 File Offset: 0x00CE40B7
		protected override void OnBeforeShow()
		{
			this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
			this.OnTimerRefresh(0f);
		}

		// Token: 0x0603677D RID: 223101 RVA: 0x00CE5EF3 File Offset: 0x00CE40F3
		protected override void OnAfterHide()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x0603677E RID: 223102 RVA: 0x00CE5F1F File Offset: 0x00CE411F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(this.OnGetRewardUpdate));
		}

		// Token: 0x0603677F RID: 223103 RVA: 0x00CE5F3D File Offset: 0x00CE413D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(this.OnGetRewardUpdate));
		}

		// Token: 0x06036780 RID: 223104 RVA: 0x00CE5F5C File Offset: 0x00CE415C
		private UniTask InitRolePortrait()
		{
			RogueTaskView.<InitRolePortrait>d__20 <InitRolePortrait>d__;
			<InitRolePortrait>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRolePortrait>d__.<>4__this = this;
			<InitRolePortrait>d__.<>1__state = -1;
			<InitRolePortrait>d__.<>t__builder.Start<RogueTaskView.<InitRolePortrait>d__20>(ref <InitRolePortrait>d__);
			return <InitRolePortrait>d__.<>t__builder.Task;
		}

		// Token: 0x06036781 RID: 223105 RVA: 0x00CE5F9F File Offset: 0x00CE419F
		private RogueTaskTabItem TabItemProxyCreate()
		{
			return new RogueTaskTabItem();
		}

		// Token: 0x06036782 RID: 223106 RVA: 0x00CE5FA6 File Offset: 0x00CE41A6
		private RogueTaskItem InitTaskItem()
		{
			return new RogueTaskItem();
		}

		// Token: 0x06036783 RID: 223107 RVA: 0x00CE5FB0 File Offset: 0x00CE41B0
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

		// Token: 0x06036784 RID: 223108 RVA: 0x00CE6049 File Offset: 0x00CE4249
		private void OnGetRewardUpdate()
		{
			this.TabLayout.GetLayoutItemByIndex(this.TabTypeList.IndexOf(this.CurrentTypeIndex)).RefreshRedDot();
			this.RefreshScrollView(this.CurrentTypeIndex);
		}

		// Token: 0x06036785 RID: 223109 RVA: 0x00CE6078 File Offset: 0x00CE4278
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

		// Token: 0x06036786 RID: 223110 RVA: 0x00CE60D0 File Offset: 0x00CE42D0
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036787 RID: 223111 RVA: 0x00CE60D9 File Offset: 0x00CE42D9
		private void OnTimerRefresh(float delta)
		{
			this.RefreshTimeTitle();
		}

		// Token: 0x06036788 RID: 223112 RVA: 0x00CE60E4 File Offset: 0x00CE42E4
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

		// Token: 0x06036789 RID: 223113 RVA: 0x00CE6214 File Offset: 0x00CE4414
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

		// Token: 0x0603678A RID: 223114 RVA: 0x00CE62A4 File Offset: 0x00CE44A4
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

		// Token: 0x0603678B RID: 223115 RVA: 0x00CE6365 File Offset: 0x00CE4565
		[CompilerGenerated]
		internal static void <RefreshTimeTitle>g__confirmCallback|30_0()
		{
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x0401CD17 RID: 118039
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RogueTaskTabItem, RogueTaskRewardTabData> TabLayout;

		// Token: 0x0401CD18 RID: 118040
		protected int CurrentTypeIndex = 1;

		// Token: 0x0401CD19 RID: 118041
		protected List<int> TabTypeList = new List<int>();

		// Token: 0x0401CD1A RID: 118042
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<RogueTaskItem, RogueTaskData> ScrollView;

		// Token: 0x0401CD1B RID: 118043
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CD1C RID: 118044
		private List<RogueTaskData> DataList = new List<RogueTaskData>();

		// Token: 0x0401CD1D RID: 118045
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0401CD1E RID: 118046
		private string RemainTimeText = "";

		// Token: 0x0401CD1F RID: 118047
		private readonly List<RogueTaskRoleItem> RoleItemList = new List<RogueTaskRoleItem>();

		// Token: 0x0401CD20 RID: 118048
		private bool TimeoutConfirm;

		// Token: 0x0401CD21 RID: 118049
		private const int MAX_ROLE_COUNT = 3;
	}
}
