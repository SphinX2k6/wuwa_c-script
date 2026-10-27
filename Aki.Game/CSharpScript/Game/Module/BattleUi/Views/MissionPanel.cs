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
	// Token: 0x02005CBF RID: 23743
	public class MissionPanel : BattleChildViewPanel
	{
		// Token: 0x0603C09C RID: 245916 RVA: 0x00E5BE94 File Offset: 0x00E5A094
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

		// Token: 0x0603C09D RID: 245917 RVA: 0x00E5BF40 File Offset: 0x00E5A140
		public override UniTask InitializeAsync()
		{
			MissionPanel.<InitializeAsync>d__8 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<MissionPanel.<InitializeAsync>d__8>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C09E RID: 245918 RVA: 0x00E5BF84 File Offset: 0x00E5A184
		private UniTask InitMissionItemView()
		{
			MissionPanel.<InitMissionItemView>d__9 <InitMissionItemView>d__;
			<InitMissionItemView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMissionItemView>d__.<>4__this = this;
			<InitMissionItemView>d__.<>1__state = -1;
			<InitMissionItemView>d__.<>t__builder.Start<MissionPanel.<InitMissionItemView>d__9>(ref <InitMissionItemView>d__);
			return <InitMissionItemView>d__.<>t__builder.Task;
		}

		// Token: 0x0603C09F RID: 245919 RVA: 0x00E5BFC8 File Offset: 0x00E5A1C8
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

		// Token: 0x0603C0A0 RID: 245920 RVA: 0x00E5C060 File Offset: 0x00E5A260
		public void SetRestoreWhenInit(bool restoreWhenInit)
		{
			this.RestoreWhenInit = restoreWhenInit;
		}

		// Token: 0x0603C0A1 RID: 245921 RVA: 0x00E5C06C File Offset: 0x00E5A26C
		private UniTask AddControllers()
		{
			MissionPanel.<AddControllers>d__12 <AddControllers>d__;
			<AddControllers>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddControllers>d__.<>4__this = this;
			<AddControllers>d__.<>1__state = -1;
			<AddControllers>d__.<>t__builder.Start<MissionPanel.<AddControllers>d__12>(ref <AddControllers>d__);
			return <AddControllers>d__.<>t__builder.Task;
		}

		// Token: 0x0603C0A2 RID: 245922 RVA: 0x00E5C0AF File Offset: 0x00E5A2AF
		private bool CheckDeleteSameTreeHandle()
		{
			return !base.GetActive();
		}

		// Token: 0x0603C0A3 RID: 245923 RVA: 0x00E5C0BC File Offset: 0x00E5A2BC
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

		// Token: 0x0603C0A4 RID: 245924 RVA: 0x00E5C120 File Offset: 0x00E5A320
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			MissionViewItem[] missionItemViews = this.MissionItemViews;
			for (int i = 0; i < missionItemViews.Length; i++)
			{
				missionItemViews[i].OnPanelShow();
			}
			((QuestUpdateTipsController)this.Controllers[1]).OnPanelShow();
		}

		// Token: 0x0603C0A5 RID: 245925 RVA: 0x00E5C15C File Offset: 0x00E5A35C
		protected override void OnHideBattleChildViewPanel()
		{
			MissionViewItem[] missionItemViews = this.MissionItemViews;
			for (int i = 0; i < missionItemViews.Length; i++)
			{
				missionItemViews[i].OnPanelHide();
			}
			((QuestUpdateTipsController)this.Controllers[1]).OnPanelHide();
		}

		// Token: 0x0603C0A6 RID: 245926 RVA: 0x00E5C198 File Offset: 0x00E5A398
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

		// Token: 0x0603C0A7 RID: 245927 RVA: 0x00E5C218 File Offset: 0x00E5A418
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

		// Token: 0x0603C0A8 RID: 245928 RVA: 0x00E5C296 File Offset: 0x00E5A496
		public override void OnTickBattleChildViewPanel(float delta)
		{
			if (!GameModeModel.Instance.WorldDoneAndLoadingClosed)
			{
				return;
			}
			((PendingProcessController)this.Controllers[0]).ProcessCacheList().Forget();
			this.TreeViewTick(delta);
		}

		// Token: 0x0603C0A9 RID: 245929 RVA: 0x00E5C2C4 File Offset: 0x00E5A4C4
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

		// Token: 0x0603C0AA RID: 245930 RVA: 0x00E5C319 File Offset: 0x00E5A519
		private bool CanShowFirstRow()
		{
			return !GameModeController.Instance.IsInInstance() || RecallQuestModel.Instance.CanMissionShowFirstRow();
		}

		// Token: 0x0603C0AB RID: 245931 RVA: 0x00E5C338 File Offset: 0x00E5A538
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

		// Token: 0x0603C0AC RID: 245932 RVA: 0x00E5C384 File Offset: 0x00E5A584
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

		// Token: 0x0603C0AD RID: 245933 RVA: 0x00E5C3D0 File Offset: 0x00E5A5D0
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

		// Token: 0x0603C0AE RID: 245934 RVA: 0x00E5C41C File Offset: 0x00E5A61C
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

		// Token: 0x0603C0AF RID: 245935 RVA: 0x00E5C470 File Offset: 0x00E5A670
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

		// Token: 0x0603C0B0 RID: 245936 RVA: 0x00E5C4EC File Offset: 0x00E5A6EC
		private int FindInPendingViewIndex(EMissionItemView viewType, long id)
		{
			List<IMissionItemViewShowData> list;
			if (this.PendingShowViewsMap.TryGetValue(viewType, out list))
			{
				return list.FindIndex((IMissionItemViewShowData value) => value.Id == id);
			}
			return -1;
		}

		// Token: 0x0603C0B1 RID: 245937 RVA: 0x00E5C52C File Offset: 0x00E5A72C
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

		// Token: 0x0603C0B2 RID: 245938 RVA: 0x00E5C590 File Offset: 0x00E5A790
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

		// Token: 0x0603C0B3 RID: 245939 RVA: 0x00E5C5EC File Offset: 0x00E5A7EC
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

		// Token: 0x0603C0B4 RID: 245940 RVA: 0x00E5C638 File Offset: 0x00E5A838
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

		// Token: 0x0603C0B5 RID: 245941 RVA: 0x00E5C684 File Offset: 0x00E5A884
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

		// Token: 0x0603C0B6 RID: 245942 RVA: 0x00E5C6E8 File Offset: 0x00E5A8E8
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

		// Token: 0x0603C0B7 RID: 245943 RVA: 0x00E5C775 File Offset: 0x00E5A975
		private void OnMissionTrackRuleChange()
		{
			this.RestoreMissionViewItemByData();
		}

		// Token: 0x0603C0B8 RID: 245944 RVA: 0x00E5C77D File Offset: 0x00E5A97D
		private void OnWorldDoneAndCloseLoading()
		{
			BattleUiModel.Instance.CheckAndUpdateRule();
		}

		// Token: 0x0603C0B9 RID: 245945 RVA: 0x00E5C78C File Offset: 0x00E5A98C
		private UniTask NewDangoAbyssInfo()
		{
			MissionPanel.<NewDangoAbyssInfo>d__36 <NewDangoAbyssInfo>d__;
			<NewDangoAbyssInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDangoAbyssInfo>d__.<>4__this = this;
			<NewDangoAbyssInfo>d__.<>1__state = -1;
			<NewDangoAbyssInfo>d__.<>t__builder.Start<MissionPanel.<NewDangoAbyssInfo>d__36>(ref <NewDangoAbyssInfo>d__);
			return <NewDangoAbyssInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0603C0BA RID: 245946 RVA: 0x00E5C7CF File Offset: 0x00E5A9CF
		protected override bool OnCheckBattleChildViewPanelShowCondition()
		{
			return BattleUiModel.Instance.IsMissionPanelVisible;
		}

		// Token: 0x0603C0BB RID: 245947 RVA: 0x00E5C7DB File Offset: 0x00E5A9DB
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

		// Token: 0x0401F50D RID: 128269
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]MissionPanelTick", "", "");

		// Token: 0x0401F50E RID: 128270
		private bool RestoreWhenInit = true;

		// Token: 0x0401F50F RID: 128271
		[Nullable(1)]
		private readonly MissionPanelControllerBase[] Controllers = new MissionPanelControllerBase[2];

		// Token: 0x0401F510 RID: 128272
		[Nullable(1)]
		private readonly MissionViewItem[] MissionItemViews = new MissionViewItem[3];

		// Token: 0x0401F511 RID: 128273
		[Nullable(1)]
		private readonly Dictionary<EMissionItemView, List<IMissionItemViewShowData>> PendingShowViewsMap = new Dictionary<EMissionItemView, List<IMissionItemViewShowData>>();

		// Token: 0x0401F512 RID: 128274
		[Nullable(2)]
		private DangoAbyssBattlePanel DangoAbyssBattlePanel;

		// Token: 0x0200BEBE RID: 48830
		private enum EChildComponent
		{
			// Token: 0x0403986D RID: 235629
			MissionItemView,
			// Token: 0x0403986E RID: 235630
			QuestUpdateTips,
			// Token: 0x0403986F RID: 235631
			MissionItemViewRoot,
			// Token: 0x04039870 RID: 235632
			ActMissionItem
		}
	}
}
