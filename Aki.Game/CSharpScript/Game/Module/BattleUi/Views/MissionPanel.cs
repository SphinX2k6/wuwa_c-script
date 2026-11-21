using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA1 RID: 19617
	public class MissionPanel : BattleChildViewPanel
	{
		// Token: 0x06030FF1 RID: 200689 RVA: 0x00DAC5A8 File Offset: 0x00DAA7A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030FF2 RID: 200690 RVA: 0x00DAC654 File Offset: 0x00DAA854
		public override UniTask InitializeAsync()
		{
			MissionPanel.<InitializeAsync>d__8 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<MissionPanel.<InitializeAsync>d__8>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030FF3 RID: 200691 RVA: 0x00DAC698 File Offset: 0x00DAA898
		private UniTask InitMissionItemView()
		{
			MissionPanel.<InitMissionItemView>d__9 <InitMissionItemView>d__;
			<InitMissionItemView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMissionItemView>d__.<>4__this = this;
			<InitMissionItemView>d__.<>1__state = -1;
			<InitMissionItemView>d__.<>t__builder.Start<MissionPanel.<InitMissionItemView>d__9>(ref <InitMissionItemView>d__);
			return <InitMissionItemView>d__.<>t__builder.Task;
		}

		// Token: 0x06030FF4 RID: 200692 RVA: 0x00DAC6DC File Offset: 0x00DAA8DC
		private void RestoreMissionViewItemByData()
		{
			Dictionary<EMissionItemView, IMissionItemViewShowData> allMissionViewData = BattleUiModel.Instance.GetAllMissionViewData();
			PendingProcessController pendingProcessController = this.Controllers[0] as PendingProcessController;
			if (allMissionViewData != null)
			{
				foreach (IMissionItemViewShowData missionItemViewShowData in allMissionViewData.Values)
				{
					EMissionItemViewDataSource dataSource = missionItemViewShowData.DataSource;
					if (dataSource != EMissionItemViewDataSource.BehaviorTree)
					{
						if (dataSource == EMissionItemViewDataSource.FishingEntrust)
						{
							pendingProcessController.FishingEntrustStartShow((FishingEntrustViewShowData)missionItemViewShowData, ETreeTextExpressReason.None);
						}
					}
					else
					{
						pendingProcessController.BehaviorTreeStartShow((BehaviorTreeViewShowData)missionItemViewShowData, ETreeTextExpressReason.None, true);
					}
				}
			}
		}

		// Token: 0x06030FF5 RID: 200693 RVA: 0x00DAC774 File Offset: 0x00DAA974
		public void SetRestoreWhenInit(bool restoreWhenInit)
		{
			this.RestoreWhenInit = restoreWhenInit;
		}

		// Token: 0x06030FF6 RID: 200694 RVA: 0x00DAC780 File Offset: 0x00DAA980
		private UniTask AddControllers()
		{
			MissionPanel.<AddControllers>d__12 <AddControllers>d__;
			<AddControllers>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddControllers>d__.<>4__this = this;
			<AddControllers>d__.<>1__state = -1;
			<AddControllers>d__.<>t__builder.Start<MissionPanel.<AddControllers>d__12>(ref <AddControllers>d__);
			return <AddControllers>d__.<>t__builder.Task;
		}

		// Token: 0x06030FF7 RID: 200695 RVA: 0x00DAC7C3 File Offset: 0x00DAA9C3
		private bool CheckDeleteSameTreeHandle()
		{
			return !base.GetActive();
		}

		// Token: 0x06030FF8 RID: 200696 RVA: 0x00DAC7D0 File Offset: 0x00DAA9D0
		public override void Reset()
		{
			this.PendingShowViewsMap.Clear();
			MissionViewItem[] missionItemViews = this.MissionItemViews;
			for (int i = 0; i < missionItemViews.Length; i++)
			{
				missionItemViews[i].Destroy(null);
			}
			Array.Clear(this.MissionItemViews);
			MissionPanelControllerBase[] controllers = this.Controllers;
			for (int i = 0; i < controllers.Length; i++)
			{
				controllers[i].OnDestroy();
			}
			base.Reset();
		}

		// Token: 0x06030FF9 RID: 200697 RVA: 0x00DAC834 File Offset: 0x00DAAA34
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			MissionViewItem[] missionItemViews = this.MissionItemViews;
			for (int i = 0; i < missionItemViews.Length; i++)
			{
				missionItemViews[i].OnPanelShow();
			}
			((QuestUpdateTipsController)this.Controllers[1]).OnPanelShow();
		}

		// Token: 0x06030FFA RID: 200698 RVA: 0x00DAC870 File Offset: 0x00DAAA70
		protected override void OnHideBattleChildViewPanel()
		{
			MissionViewItem[] missionItemViews = this.MissionItemViews;
			for (int i = 0; i < missionItemViews.Length; i++)
			{
				missionItemViews[i].OnPanelHide();
			}
			((QuestUpdateTipsController)this.Controllers[1]).OnPanelHide();
		}

		// Token: 0x06030FFB RID: 200699 RVA: 0x00DAC8AC File Offset: 0x00DAAAAC
		protected override void AddEvents()
		{
			MissionPanelControllerBase[] controllers = this.Controllers;
			for (int i = 0; i < controllers.Length; i++)
			{
				controllers[i].AddEvents();
			}
			EventSystem.Instance.Add(EEventName.QuestUpdateTipsEndSequenceStart, new Action(this.OnQuestUpdateTipsEndSequenceStart));
			EventSystem.Instance.Add(EEventName.MissionTrackRuleChange, new Action(this.OnMissionTrackRuleChange));
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x06030FFC RID: 200700 RVA: 0x00DAC92C File Offset: 0x00DAAB2C
		protected override void RemoveEvents()
		{
			MissionPanelControllerBase[] controllers = this.Controllers;
			for (int i = 0; i < controllers.Length; i++)
			{
				controllers[i].RemoveEvents();
			}
			EventSystem.Instance.Remove(EEventName.QuestUpdateTipsEndSequenceStart, new Action(this.OnQuestUpdateTipsEndSequenceStart));
			EventSystem.Instance.Remove(EEventName.MissionTrackRuleChange, new Action(this.OnMissionTrackRuleChange));
			EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
		}

		// Token: 0x06030FFD RID: 200701 RVA: 0x00DAC9AA File Offset: 0x00DAABAA
		public override void OnTickBattleChildViewPanel(float delta)
		{
			if (!GameModeModel.Instance.WorldDoneAndLoadingClosed)
			{
				return;
			}
			((PendingProcessController)this.Controllers[0]).ProcessCacheList().Forget();
			this.TreeViewTick(delta);
		}

		// Token: 0x06030FFE RID: 200702 RVA: 0x00DAC9D8 File Offset: 0x00DAABD8
		private void TreeViewTick(float delta)
		{
			if (this.MissionItemViews[0] == null)
			{
				return;
			}
			TPendingProcess currentProcess = ((PendingProcessController)this.Controllers[0]).GetCurrentProcess();
			MissionViewItem[] missionItemViews = this.MissionItemViews;
			for (int i = 0; i < missionItemViews.Length; i++)
			{
				missionItemViews[i].OnRefresh(delta, (currentProcess != null) ? currentProcess.ProcessId : 0);
			}
		}

		// Token: 0x06030FFF RID: 200703 RVA: 0x00DACA2D File Offset: 0x00DAAC2D
		private bool CanShowFirstRow()
		{
			return !GameModeController.Instance.IsInInstance() || RecallQuestModel.Instance.CanMissionShowFirstRow();
		}

		// Token: 0x06031000 RID: 200704 RVA: 0x00DACA4C File Offset: 0x00DAAC4C
		private UniTask<bool> MissionItemViewStartTrackHandle([Nullable(1)] MissionItemViewStartTrackProcess processInfo)
		{
			MissionPanel.<MissionItemViewStartTrackHandle>d__22 <MissionItemViewStartTrackHandle>d__;
			<MissionItemViewStartTrackHandle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MissionItemViewStartTrackHandle>d__.<>4__this = this;
			<MissionItemViewStartTrackHandle>d__.processInfo = processInfo;
			<MissionItemViewStartTrackHandle>d__.<>1__state = -1;
			<MissionItemViewStartTrackHandle>d__.<>t__builder.Start<MissionPanel.<MissionItemViewStartTrackHandle>d__22>(ref <MissionItemViewStartTrackHandle>d__);
			return <MissionItemViewStartTrackHandle>d__.<>t__builder.Task;
		}

		// Token: 0x06031001 RID: 200705 RVA: 0x00DACA98 File Offset: 0x00DAAC98
		private UniTask<bool> MissionItemViewRefreshHandle([Nullable(1)] MissionItemViewRefreshProcess process)
		{
			MissionPanel.<MissionItemViewRefreshHandle>d__23 <MissionItemViewRefreshHandle>d__;
			<MissionItemViewRefreshHandle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MissionItemViewRefreshHandle>d__.<>4__this = this;
			<MissionItemViewRefreshHandle>d__.process = process;
			<MissionItemViewRefreshHandle>d__.<>1__state = -1;
			<MissionItemViewRefreshHandle>d__.<>t__builder.Start<MissionPanel.<MissionItemViewRefreshHandle>d__23>(ref <MissionItemViewRefreshHandle>d__);
			return <MissionItemViewRefreshHandle>d__.<>t__builder.Task;
		}

		// Token: 0x06031002 RID: 200706 RVA: 0x00DACAE4 File Offset: 0x00DAACE4
		private UniTask<bool> MissionItemViewEndTrackHandle([Nullable(1)] MissionItemViewEndTrackProcess processInfo)
		{
			MissionPanel.<MissionItemViewEndTrackHandle>d__24 <MissionItemViewEndTrackHandle>d__;
			<MissionItemViewEndTrackHandle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MissionItemViewEndTrackHandle>d__.<>4__this = this;
			<MissionItemViewEndTrackHandle>d__.processInfo = processInfo;
			<MissionItemViewEndTrackHandle>d__.<>1__state = -1;
			<MissionItemViewEndTrackHandle>d__.<>t__builder.Start<MissionPanel.<MissionItemViewEndTrackHandle>d__24>(ref <MissionItemViewEndTrackHandle>d__);
			return <MissionItemViewEndTrackHandle>d__.<>t__builder.Task;
		}

		// Token: 0x06031003 RID: 200707 RVA: 0x00DACB30 File Offset: 0x00DAAD30
		private UniTask<bool> CheckPendingShowViews(EMissionItemView viewType, [Nullable(1)] MissionItemViewEndTrackProcess processInfo)
		{
			MissionPanel.<CheckPendingShowViews>d__25 <CheckPendingShowViews>d__;
			<CheckPendingShowViews>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CheckPendingShowViews>d__.<>4__this = this;
			<CheckPendingShowViews>d__.viewType = viewType;
			<CheckPendingShowViews>d__.processInfo = processInfo;
			<CheckPendingShowViews>d__.<>1__state = -1;
			<CheckPendingShowViews>d__.<>t__builder.Start<MissionPanel.<CheckPendingShowViews>d__25>(ref <CheckPendingShowViews>d__);
			return <CheckPendingShowViews>d__.<>t__builder.Task;
		}

		// Token: 0x06031004 RID: 200708 RVA: 0x00DACB84 File Offset: 0x00DAAD84
		[NullableContext(1)]
		private void UpdatePendingShowViews(IMissionItemViewShowData showData)
		{
			foreach (KeyValuePair<EMissionItemView, List<IMissionItemViewShowData>> keyValuePair in this.PendingShowViewsMap)
			{
				EMissionItemView emissionItemView;
				List<IMissionItemViewShowData> list;
				keyValuePair.Deconstruct(out emissionItemView, out list);
				EMissionItemView viewType = emissionItemView;
				List<IMissionItemViewShowData> list2 = list;
				int num = this.FindInPendingViewIndex(viewType, showData.Id);
				if (num >= 1)
				{
					list2[num] = showData;
				}
			}
		}

		// Token: 0x06031005 RID: 200709 RVA: 0x00DACC00 File Offset: 0x00DAAE00
		private int FindInPendingViewIndex(EMissionItemView viewType, long id)
		{
			List<IMissionItemViewShowData> list;
			if (this.PendingShowViewsMap.TryGetValue(viewType, out list))
			{
				return list.FindIndex((IMissionItemViewShowData value) => value.Id == id);
			}
			return -1;
		}

		// Token: 0x06031006 RID: 200710 RVA: 0x00DACC40 File Offset: 0x00DAAE40
		private UniTask<bool> TryUsePendingViewShow(EMissionItemView viewType, int processId, [Nullable(1)] IMissionItemViewShowData showData, bool bSkipAnim)
		{
			MissionPanel.<TryUsePendingViewShow>d__28 <TryUsePendingViewShow>d__;
			<TryUsePendingViewShow>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryUsePendingViewShow>d__.<>4__this = this;
			<TryUsePendingViewShow>d__.viewType = viewType;
			<TryUsePendingViewShow>d__.processId = processId;
			<TryUsePendingViewShow>d__.showData = showData;
			<TryUsePendingViewShow>d__.bSkipAnim = bSkipAnim;
			<TryUsePendingViewShow>d__.<>1__state = -1;
			<TryUsePendingViewShow>d__.<>t__builder.Start<MissionPanel.<TryUsePendingViewShow>d__28>(ref <TryUsePendingViewShow>d__);
			return <TryUsePendingViewShow>d__.<>t__builder.Task;
		}

		// Token: 0x06031007 RID: 200711 RVA: 0x00DACCA4 File Offset: 0x00DAAEA4
		private UniTask<bool> UpdatePendingShowView(EMissionItemView viewType, int processId, bool bSkipAnim)
		{
			MissionPanel.<UpdatePendingShowView>d__29 <UpdatePendingShowView>d__;
			<UpdatePendingShowView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdatePendingShowView>d__.<>4__this = this;
			<UpdatePendingShowView>d__.viewType = viewType;
			<UpdatePendingShowView>d__.processId = processId;
			<UpdatePendingShowView>d__.bSkipAnim = bSkipAnim;
			<UpdatePendingShowView>d__.<>1__state = -1;
			<UpdatePendingShowView>d__.<>t__builder.Start<MissionPanel.<UpdatePendingShowView>d__29>(ref <UpdatePendingShowView>d__);
			return <UpdatePendingShowView>d__.<>t__builder.Task;
		}

		// Token: 0x06031008 RID: 200712 RVA: 0x00DACD00 File Offset: 0x00DAAF00
		private UniTask<bool> ShowQuestUpdateTipsHandle([Nullable(1)] ShowQuestUpdateTipsProcess process)
		{
			MissionPanel.<ShowQuestUpdateTipsHandle>d__30 <ShowQuestUpdateTipsHandle>d__;
			<ShowQuestUpdateTipsHandle>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowQuestUpdateTipsHandle>d__.<>4__this = this;
			<ShowQuestUpdateTipsHandle>d__.process = process;
			<ShowQuestUpdateTipsHandle>d__.<>1__state = -1;
			<ShowQuestUpdateTipsHandle>d__.<>t__builder.Start<MissionPanel.<ShowQuestUpdateTipsHandle>d__30>(ref <ShowQuestUpdateTipsHandle>d__);
			return <ShowQuestUpdateTipsHandle>d__.<>t__builder.Task;
		}

		// Token: 0x06031009 RID: 200713 RVA: 0x00DACD4C File Offset: 0x00DAAF4C
		private UniTask<bool> StepConditionIndexChange([Nullable(1)] StepConditionIndexChangeProcess process)
		{
			MissionPanel.<StepConditionIndexChange>d__31 <StepConditionIndexChange>d__;
			<StepConditionIndexChange>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StepConditionIndexChange>d__.<>4__this = this;
			<StepConditionIndexChange>d__.process = process;
			<StepConditionIndexChange>d__.<>1__state = -1;
			<StepConditionIndexChange>d__.<>t__builder.Start<MissionPanel.<StepConditionIndexChange>d__31>(ref <StepConditionIndexChange>d__);
			return <StepConditionIndexChange>d__.<>t__builder.Task;
		}

		// Token: 0x0603100A RID: 200714 RVA: 0x00DACD98 File Offset: 0x00DAAF98
		private bool CheckMissionItemViewShowEmptyHandle()
		{
			for (int i = 0; i < this.MissionItemViews.Length; i++)
			{
				MissionViewItem missionViewItem = this.MissionItemViews[i];
				Dictionary<EMissionItemView, bool> isShowingMissionViewItems = BattleUiModel.Instance.IsShowingMissionViewItems;
				if (((isShowingMissionViewItems != null) ? new bool?(isShowingMissionViewItems.GetValueOrDefault((EMissionItemView)i)) : null).GetValueOrDefault() && missionViewItem.CheckVisible())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603100B RID: 200715 RVA: 0x00DACDFC File Offset: 0x00DAAFFC
		private void OnQuestUpdateTipsEndSequenceStart()
		{
			TPendingProcess currentProcess = ((PendingProcessController)this.Controllers[0]).GetCurrentProcess();
			if (currentProcess == null)
			{
				Log.Instance.Error(ELogModule.Quest, ELogAuthor.YSQ, "MissionPanel:任务更新提示结束动画开始时找不到当前正在处理的操作", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			ShowQuestUpdateTipsProcess showQuestUpdateTipsProcess = currentProcess as ShowQuestUpdateTipsProcess;
			if (showQuestUpdateTipsProcess == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Quest;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "MissionPanel:任务更新提示结束动画开始时当前正在处理的操作类型异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("processType", currentProcess.ProcessType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.UpdatePendingShowViews(showQuestUpdateTipsProcess.Info.MissionViewShowData);
		}

		// Token: 0x0603100C RID: 200716 RVA: 0x00DACE89 File Offset: 0x00DAB089
		private void OnMissionTrackRuleChange()
		{
			this.RestoreMissionViewItemByData();
		}

		// Token: 0x0603100D RID: 200717 RVA: 0x00DACE91 File Offset: 0x00DAB091
		private void OnWorldDoneAndCloseLoading()
		{
			BattleUiModel.Instance.CheckAndUpdateRule();
		}

		// Token: 0x0603100E RID: 200718 RVA: 0x00DACEA0 File Offset: 0x00DAB0A0
		private UniTask NewDangoAbyssInfo()
		{
			MissionPanel.<NewDangoAbyssInfo>d__36 <NewDangoAbyssInfo>d__;
			<NewDangoAbyssInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDangoAbyssInfo>d__.<>4__this = this;
			<NewDangoAbyssInfo>d__.<>1__state = -1;
			<NewDangoAbyssInfo>d__.<>t__builder.Start<MissionPanel.<NewDangoAbyssInfo>d__36>(ref <NewDangoAbyssInfo>d__);
			return <NewDangoAbyssInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0603100F RID: 200719 RVA: 0x00DACEE3 File Offset: 0x00DAB0E3
		protected override bool OnCheckBattleChildViewPanelShowCondition()
		{
			return BattleUiModel.Instance.IsMissionPanelVisible;
		}

		// Token: 0x06031010 RID: 200720 RVA: 0x00DACEEF File Offset: 0x00DAB0EF
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			DangoAbyssBattlePanel dangoAbyssBattlePanel = this.DangoAbyssBattlePanel;
			if (dangoAbyssBattlePanel == null)
			{
				return null;
			}
			return dangoAbyssBattlePanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x04019FC6 RID: 106438
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]MissionPanelTick", "", "");

		// Token: 0x04019FC7 RID: 106439
		private bool RestoreWhenInit = true;

		// Token: 0x04019FC8 RID: 106440
		[Nullable(1)]
		private readonly MissionPanelControllerBase[] Controllers = new MissionPanelControllerBase[2];

		// Token: 0x04019FC9 RID: 106441
		[Nullable(1)]
		private readonly MissionViewItem[] MissionItemViews = new MissionViewItem[3];

		// Token: 0x04019FCA RID: 106442
		[Nullable(1)]
		private readonly Dictionary<EMissionItemView, List<IMissionItemViewShowData>> PendingShowViewsMap = new Dictionary<EMissionItemView, List<IMissionItemViewShowData>>();

		// Token: 0x04019FCB RID: 106443
		[Nullable(2)]
		private DangoAbyssBattlePanel DangoAbyssBattlePanel;

		// Token: 0x0200A8C4 RID: 43204
		private enum EChildComponent
		{
			// Token: 0x0403422E RID: 213550
			MissionItemView,
			// Token: 0x0403422F RID: 213551
			QuestUpdateTips,
			// Token: 0x04034230 RID: 213552
			MissionItemViewRoot,
			// Token: 0x04034231 RID: 213553
			ActMissionItem
		}
	}
}
