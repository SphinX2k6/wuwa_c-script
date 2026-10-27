using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D86 RID: 23942
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingProcessController : MissionPanelControllerBase
	{
		// Token: 0x0603CC42 RID: 248898 RVA: 0x00E96AF0 File Offset: 0x00E94CF0
		public PendingProcessController(Func<bool> checkDeleteSameTreeHandle, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<MissionItemViewStartTrackProcess, UniTask<bool>> missionItemViewStartTrackHandle, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<MissionItemViewEndTrackProcess, UniTask<bool>> missionItemViewEndTrackHandle, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<MissionItemViewRefreshProcess, UniTask<bool>> missionItemViewRefreshHandle, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<ShowQuestUpdateTipsProcess, UniTask<bool>> showQuestUpdateTipsHandle, [Nullable(new byte[]
		{
			1,
			1,
			0
		})] Func<StepConditionIndexChangeProcess, UniTask<bool>> stepConditionIndexChange)
		{
		}

		// Token: 0x17008E5F RID: 36447
		// (get) Token: 0x0603CC43 RID: 248899 RVA: 0x00E96B47 File Offset: 0x00E94D47
		protected override EMissionPanelControllerType ControllerType
		{
			get
			{
				return EMissionPanelControllerType.PendingProcessController;
			}
		}

		// Token: 0x0603CC44 RID: 248900 RVA: 0x00E96B4A File Offset: 0x00E94D4A
		public override void OnDestroy()
		{
			this.CurProcess = null;
			this.ProcessQueue.Clear();
			this.AddToFirstProcessQueue.Clear();
		}

		// Token: 0x0603CC45 RID: 248901 RVA: 0x00E96B6C File Offset: 0x00E94D6C
		public override void AddEvents()
		{
			EventSystem.Instance.Add<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeStartShowTrackText, new Action<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(this.BehaviorTreeStartShow));
			EventSystem.Instance.Add<FishingEntrustViewShowData, ETreeTextExpressReason>(EEventName.FishingEntrustStartShowTrackText, new Action<FishingEntrustViewShowData, ETreeTextExpressReason>(this.FishingEntrustStartShow));
			EventSystem.Instance.Add<int, ETreeTextExpressReason>(EEventName.FishingEntrustEndShowTrackText, new Action<int, ETreeTextExpressReason>(this.FishingEntrustEndShow));
			EventSystem.Instance.Add<bool>(EEventName.DriveFishingShipStateChanged, new Action<bool>(this.OnDriveFishingShipStateChanged));
			EventSystem.Instance.Add<long, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeEndShowTrackText, new Action<long, ETreeTextExpressReason, bool>(this.BehaviorTreeEndShow));
			EventSystem.Instance.Add<BehaviorTreeViewShowData, bool>(EEventName.GeneralLogicTreeUpdateShowTrackText, new Action<BehaviorTreeViewShowData, bool>(this.OnLogicTreeUpdateShow));
			EventSystem.Instance.Add<QuestUpdateTipsShowData>(EEventName.QuestUpdateInfoAdd, new Action<QuestUpdateTipsShowData>(this.ShowQuestUpdateTips));
			EventSystem.Instance.Add<int>(EEventName.OnFishingSailing, new Action<int>(this.OnFishingSailing));
			EventSystem.Instance.Add<EMissionItemView, int, int?>(EEventName.MissionPanelStepConditionIndexChange, new Action<EMissionItemView, int, int?>(this.OnStepConditionIndexChange));
			EventSystem.Instance.Add<int>(EEventName.FocusQuestChange, new Action<int>(this.OnFocusQuestChange));
		}

		// Token: 0x0603CC46 RID: 248902 RVA: 0x00E96C94 File Offset: 0x00E94E94
		public override void RemoveEvents()
		{
			EventSystem.Instance.Remove<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeStartShowTrackText, new Action<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(this.BehaviorTreeStartShow));
			EventSystem.Instance.Remove<FishingEntrustViewShowData, ETreeTextExpressReason>(EEventName.FishingEntrustStartShowTrackText, new Action<FishingEntrustViewShowData, ETreeTextExpressReason>(this.FishingEntrustStartShow));
			EventSystem.Instance.Remove<int, ETreeTextExpressReason>(EEventName.FishingEntrustEndShowTrackText, new Action<int, ETreeTextExpressReason>(this.FishingEntrustEndShow));
			EventSystem.Instance.Remove<bool>(EEventName.DriveFishingShipStateChanged, new Action<bool>(this.OnDriveFishingShipStateChanged));
			EventSystem.Instance.Remove<long, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeEndShowTrackText, new Action<long, ETreeTextExpressReason, bool>(this.BehaviorTreeEndShow));
			EventSystem.Instance.Remove<BehaviorTreeViewShowData, bool>(EEventName.GeneralLogicTreeUpdateShowTrackText, new Action<BehaviorTreeViewShowData, bool>(this.OnLogicTreeUpdateShow));
			EventSystem.Instance.Remove<QuestUpdateTipsShowData>(EEventName.QuestUpdateInfoAdd, new Action<QuestUpdateTipsShowData>(this.ShowQuestUpdateTips));
			EventSystem.Instance.Remove<int>(EEventName.OnFishingSailing, new Action<int>(this.OnFishingSailing));
			EventSystem.Instance.Remove<EMissionItemView, int, int?>(EEventName.MissionPanelStepConditionIndexChange, new Action<EMissionItemView, int, int?>(this.OnStepConditionIndexChange));
			EventSystem.Instance.Remove<int>(EEventName.FocusQuestChange, new Action<int>(this.OnFocusQuestChange));
		}

		// Token: 0x0603CC47 RID: 248903 RVA: 0x00E96DB9 File Offset: 0x00E94FB9
		private void OnDriveFishingShipStateChanged(bool isDriving)
		{
			if (isDriving)
			{
				FishingQuestModel.Instance.StartShowTrackText(FishingQuestModel.Instance.CurrentTraceEntrust, ETreeTextExpressReason.DrivingStateChange);
				return;
			}
			this.FishingEntrustEndShow(this.FishingEntrustViewShowId, ETreeTextExpressReason.DrivingStateChange);
		}

		// Token: 0x0603CC48 RID: 248904 RVA: 0x00E96DE1 File Offset: 0x00E94FE1
		private void OnFishingSailing(int id)
		{
			this.FishingEntrustEndShow(this.FishingEntrustViewShowId, ETreeTextExpressReason.OnFishingSailing);
			if (id > 0)
			{
				FishingQuestModel.Instance.StartShowTrackText(id, ETreeTextExpressReason.OnFishingSailing);
			}
		}

		// Token: 0x0603CC49 RID: 248905 RVA: 0x00E96E00 File Offset: 0x00E95000
		public void FishingEntrustStartShow(FishingEntrustViewShowData showData, ETreeTextExpressReason reason)
		{
			if (!FishingModel.Instance.GetShipData().IsShipDriving())
			{
				return;
			}
			if (reason - ETreeTextExpressReason.DrivingStateChange > 1 && UiManager.Instance.GetViewByName(EUiViewName.FishingDockView) != null)
			{
				return;
			}
			bool isSkipAnim = AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled;
			if ((long)this.FishingEntrustViewShowId == showData.Id)
			{
				this.AddNewProcess(new MissionItemViewRefreshProcess(showData, isSkipAnim));
			}
			else
			{
				this.AddNewProcess(new MissionItemViewStartTrackProcess(showData, reason, isSkipAnim));
			}
			this.FishingEntrustViewShowId = (int)showData.Id;
		}

		// Token: 0x0603CC4A RID: 248906 RVA: 0x00E96E80 File Offset: 0x00E95080
		private void FishingEntrustEndShow(int id, ETreeTextExpressReason reason)
		{
			bool isSkipAnim = AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled;
			if (reason != ETreeTextExpressReason.DrivingStateChange)
			{
				if (reason == ETreeTextExpressReason.OnFishingSailing)
				{
					isSkipAnim = true;
				}
				else if (UiManager.Instance.GetViewByName(EUiViewName.FishingDockView) != null)
				{
					return;
				}
			}
			this.AddNewProcess(new MissionItemViewEndTrackProcess((long)id, (int)reason, isSkipAnim));
			this.FishingEntrustViewShowId = 0;
		}

		// Token: 0x0603CC4B RID: 248907 RVA: 0x00E96ED0 File Offset: 0x00E950D0
		public void BehaviorTreeStartShow(BehaviorTreeViewShowData showData, ETreeTextExpressReason reason, bool bSkipAnim)
		{
			if (this.<checkDeleteSameTreeHandle>P())
			{
				this.DeleteSameTreeProcess(showData.Id);
			}
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(showData.Id), false);
			if (behaviorTree != null && behaviorTree.GetBlackBoard().ContainTag(EBehaviorTreeTag.BindingLevelPlayTrack))
			{
				this.DeleteSameTreeProcess(showData.Id);
			}
			this.AddNewProcess(new MissionItemViewStartTrackProcess(showData, reason, bSkipAnim));
		}

		// Token: 0x0603CC4C RID: 248908 RVA: 0x00E96F3C File Offset: 0x00E9513C
		private void BehaviorTreeEndShow(long treeIncId, ETreeTextExpressReason reason, bool bSkipAnim)
		{
			if (this.<checkDeleteSameTreeHandle>P())
			{
				this.DeleteSameTreeProcess(treeIncId);
			}
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree != null && behaviorTree.GetBlackBoard().ContainTag(EBehaviorTreeTag.BindingLevelPlayTrack))
			{
				this.DeleteSameTreeProcess(treeIncId);
			}
			this.AddNewProcess(new MissionItemViewEndTrackProcess(treeIncId, (int)reason, bSkipAnim));
		}

		// Token: 0x0603CC4D RID: 248909 RVA: 0x00E96F98 File Offset: 0x00E95198
		private void DeleteSameTreeProcess(long id)
		{
			if (this.ProcessQueue.Count == 0)
			{
				return;
			}
			for (int i = 0; i < this.ProcessQueue.Count; i++)
			{
				TPendingProcess tpendingProcess = this.ProcessQueue[i];
				bool flag = false;
				MissionItemViewStartTrackProcess missionItemViewStartTrackProcess = tpendingProcess as MissionItemViewStartTrackProcess;
				if (missionItemViewStartTrackProcess == null)
				{
					MissionItemViewRefreshProcess missionItemViewRefreshProcess = tpendingProcess as MissionItemViewRefreshProcess;
					if (missionItemViewRefreshProcess == null)
					{
						MissionItemViewEndTrackProcess missionItemViewEndTrackProcess = tpendingProcess as MissionItemViewEndTrackProcess;
						if (missionItemViewEndTrackProcess == null)
						{
							ShowQuestUpdateTipsProcess showQuestUpdateTipsProcess = tpendingProcess as ShowQuestUpdateTipsProcess;
							if (showQuestUpdateTipsProcess != null)
							{
								flag = (showQuestUpdateTipsProcess.Info.MissionViewShowData.Id == id);
							}
						}
						else
						{
							flag = (missionItemViewEndTrackProcess.Id == id);
						}
					}
					else
					{
						flag = (missionItemViewRefreshProcess.ShowData.Id == id);
					}
				}
				else
				{
					flag = (missionItemViewStartTrackProcess.ShowData.Id == id);
				}
				bool flag2 = this.CurProcess != null && this.CurProcess.ProcessId == tpendingProcess.ProcessId;
				if (flag && !flag2)
				{
					this.ProcessQueue.RemoveAt(i);
				}
			}
		}

		// Token: 0x0603CC4E RID: 248910 RVA: 0x00E97087 File Offset: 0x00E95287
		private void OnLogicTreeUpdateShow(BehaviorTreeViewShowData showData, bool bSkipAnim)
		{
			this.AddNewProcess(new MissionItemViewRefreshProcess(showData, bSkipAnim));
		}

		// Token: 0x0603CC4F RID: 248911 RVA: 0x00E97096 File Offset: 0x00E95296
		private void ShowQuestUpdateTips(QuestUpdateTipsShowData info)
		{
			this.AddNewProcess(new ShowQuestUpdateTipsProcess(info));
		}

		// Token: 0x0603CC50 RID: 248912 RVA: 0x00E970A4 File Offset: 0x00E952A4
		private void OnStepConditionIndexChange(EMissionItemView viewId, int stepId, int? curConditionTextIndex)
		{
			this.AddNewProcessToFirst(new StepConditionIndexChangeProcess(viewId, stepId, curConditionTextIndex));
		}

		// Token: 0x0603CC51 RID: 248913 RVA: 0x00E970B4 File Offset: 0x00E952B4
		private void OnFocusQuestChange(int questId)
		{
			if (questId == 0 || this.ProcessQueue.Count == 0)
			{
				return;
			}
			for (int i = this.ProcessQueue.Count - 1; i >= 0; i--)
			{
				TPendingProcess tpendingProcess = this.ProcessQueue[i];
				ShowQuestUpdateTipsProcess showQuestUpdateTipsProcess = tpendingProcess as ShowQuestUpdateTipsProcess;
				if (showQuestUpdateTipsProcess != null && questId != showQuestUpdateTipsProcess.Info.QuestId && this.CurProcess != tpendingProcess)
				{
					this.ProcessQueue.RemoveAt(i);
				}
			}
		}

		// Token: 0x0603CC52 RID: 248914 RVA: 0x00E97124 File Offset: 0x00E95324
		private void AddNewProcess(TPendingProcess processInfo)
		{
			foreach (PendingProcessControllerRuleConfigBase pendingProcessControllerRuleConfigBase in PendingProcessControllerRuleConfigInstance.Instance.PendingProcessExCheckList)
			{
				if (pendingProcessControllerRuleConfigBase.IsActive() && !pendingProcessControllerRuleConfigBase.PendingProgressExCheck(processInfo))
				{
					return;
				}
			}
			this.ProcessQueue.Add(processInfo);
		}

		// Token: 0x0603CC53 RID: 248915 RVA: 0x00E97190 File Offset: 0x00E95390
		private void AddNewProcessToFirst(TPendingProcess processInfo)
		{
			if (this.CurProcess != null)
			{
				this.AddToFirstProcessQueue.Push(processInfo);
				return;
			}
			this.ProcessQueue.Insert(0, processInfo);
		}

		// Token: 0x0603CC54 RID: 248916 RVA: 0x00E971B4 File Offset: 0x00E953B4
		public UniTask ProcessCacheList()
		{
			PendingProcessController.<ProcessCacheList>d__29 <ProcessCacheList>d__;
			<ProcessCacheList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessCacheList>d__.<>4__this = this;
			<ProcessCacheList>d__.<>1__state = -1;
			<ProcessCacheList>d__.<>t__builder.Start<PendingProcessController.<ProcessCacheList>d__29>(ref <ProcessCacheList>d__);
			return <ProcessCacheList>d__.<>t__builder.Task;
		}

		// Token: 0x0603CC55 RID: 248917 RVA: 0x00E971F7 File Offset: 0x00E953F7
		[NullableContext(2)]
		public TPendingProcess GetCurrentProcess()
		{
			return this.CurProcess;
		}

		// Token: 0x0401FA7B RID: 129659
		[CompilerGenerated]
		private Func<bool> <checkDeleteSameTreeHandle>P = checkDeleteSameTreeHandle;

		// Token: 0x0401FA7C RID: 129660
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<MissionItemViewStartTrackProcess, UniTask<bool>> <missionItemViewStartTrackHandle>P = missionItemViewStartTrackHandle;

		// Token: 0x0401FA7D RID: 129661
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<MissionItemViewEndTrackProcess, UniTask<bool>> <missionItemViewEndTrackHandle>P = missionItemViewEndTrackHandle;

		// Token: 0x0401FA7E RID: 129662
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<MissionItemViewRefreshProcess, UniTask<bool>> <missionItemViewRefreshHandle>P = missionItemViewRefreshHandle;

		// Token: 0x0401FA7F RID: 129663
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<ShowQuestUpdateTipsProcess, UniTask<bool>> <showQuestUpdateTipsHandle>P = showQuestUpdateTipsHandle;

		// Token: 0x0401FA80 RID: 129664
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<StepConditionIndexChangeProcess, UniTask<bool>> <stepConditionIndexChange>P = stepConditionIndexChange;

		// Token: 0x0401FA81 RID: 129665
		private readonly List<TPendingProcess> ProcessQueue = new List<TPendingProcess>();

		// Token: 0x0401FA82 RID: 129666
		private readonly Queue<TPendingProcess> AddToFirstProcessQueue = new Queue<TPendingProcess>(4);

		// Token: 0x0401FA83 RID: 129667
		[Nullable(2)]
		private TPendingProcess CurProcess;

		// Token: 0x0401FA84 RID: 129668
		private int FishingEntrustViewShowId;
	}
}
