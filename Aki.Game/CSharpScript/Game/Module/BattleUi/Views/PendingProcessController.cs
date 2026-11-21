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
	// Token: 0x02004D68 RID: 19816
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingProcessController : MissionPanelControllerBase
	{
		// Token: 0x06031B9E RID: 203678 RVA: 0x00DE7338 File Offset: 0x00DE5538
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

		// Token: 0x17006231 RID: 25137
		// (get) Token: 0x06031B9F RID: 203679 RVA: 0x00DE738F File Offset: 0x00DE558F
		protected override EMissionPanelControllerType ControllerType
		{
			get
			{
				return EMissionPanelControllerType.PendingProcessController;
			}
		}

		// Token: 0x06031BA0 RID: 203680 RVA: 0x00DE7392 File Offset: 0x00DE5592
		public override void OnDestroy()
		{
			this.CurProcess = null;
			this.ProcessQueue.Clear();
			this.AddToFirstProcessQueue.Clear();
		}

		// Token: 0x06031BA1 RID: 203681 RVA: 0x00DE73B4 File Offset: 0x00DE55B4
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

		// Token: 0x06031BA2 RID: 203682 RVA: 0x00DE74DC File Offset: 0x00DE56DC
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

		// Token: 0x06031BA3 RID: 203683 RVA: 0x00DE7601 File Offset: 0x00DE5801
		private void OnDriveFishingShipStateChanged(bool isDriving)
		{
			if (isDriving)
			{
				FishingQuestModel.Instance.StartShowTrackText(FishingQuestModel.Instance.CurrentTraceEntrust, ETreeTextExpressReason.DrivingStateChange);
				return;
			}
			this.FishingEntrustEndShow(this.FishingEntrustViewShowId, ETreeTextExpressReason.DrivingStateChange);
		}

		// Token: 0x06031BA4 RID: 203684 RVA: 0x00DE7629 File Offset: 0x00DE5829
		private void OnFishingSailing(int id)
		{
			this.FishingEntrustEndShow(this.FishingEntrustViewShowId, ETreeTextExpressReason.OnFishingSailing);
			if (id > 0)
			{
				FishingQuestModel.Instance.StartShowTrackText(id, ETreeTextExpressReason.OnFishingSailing);
			}
		}

		// Token: 0x06031BA5 RID: 203685 RVA: 0x00DE7648 File Offset: 0x00DE5848
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

		// Token: 0x06031BA6 RID: 203686 RVA: 0x00DE76C8 File Offset: 0x00DE58C8
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

		// Token: 0x06031BA7 RID: 203687 RVA: 0x00DE7718 File Offset: 0x00DE5918
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

		// Token: 0x06031BA8 RID: 203688 RVA: 0x00DE7784 File Offset: 0x00DE5984
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

		// Token: 0x06031BA9 RID: 203689 RVA: 0x00DE77E0 File Offset: 0x00DE59E0
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

		// Token: 0x06031BAA RID: 203690 RVA: 0x00DE78CF File Offset: 0x00DE5ACF
		private void OnLogicTreeUpdateShow(BehaviorTreeViewShowData showData, bool bSkipAnim)
		{
			this.AddNewProcess(new MissionItemViewRefreshProcess(showData, bSkipAnim));
		}

		// Token: 0x06031BAB RID: 203691 RVA: 0x00DE78DE File Offset: 0x00DE5ADE
		private void ShowQuestUpdateTips(QuestUpdateTipsShowData info)
		{
			this.AddNewProcess(new ShowQuestUpdateTipsProcess(info));
		}

		// Token: 0x06031BAC RID: 203692 RVA: 0x00DE78EC File Offset: 0x00DE5AEC
		private void OnStepConditionIndexChange(EMissionItemView viewId, int stepId, int? curConditionTextIndex)
		{
			this.AddNewProcessToFirst(new StepConditionIndexChangeProcess(viewId, stepId, curConditionTextIndex));
		}

		// Token: 0x06031BAD RID: 203693 RVA: 0x00DE78FC File Offset: 0x00DE5AFC
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

		// Token: 0x06031BAE RID: 203694 RVA: 0x00DE796C File Offset: 0x00DE5B6C
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

		// Token: 0x06031BAF RID: 203695 RVA: 0x00DE79D8 File Offset: 0x00DE5BD8
		private void AddNewProcessToFirst(TPendingProcess processInfo)
		{
			if (this.CurProcess != null)
			{
				this.AddToFirstProcessQueue.Push(processInfo);
				return;
			}
			this.ProcessQueue.Insert(0, processInfo);
		}

		// Token: 0x06031BB0 RID: 203696 RVA: 0x00DE79FC File Offset: 0x00DE5BFC
		public UniTask ProcessCacheList()
		{
			PendingProcessController.<ProcessCacheList>d__29 <ProcessCacheList>d__;
			<ProcessCacheList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessCacheList>d__.<>4__this = this;
			<ProcessCacheList>d__.<>1__state = -1;
			<ProcessCacheList>d__.<>t__builder.Start<PendingProcessController.<ProcessCacheList>d__29>(ref <ProcessCacheList>d__);
			return <ProcessCacheList>d__.<>t__builder.Task;
		}

		// Token: 0x06031BB1 RID: 203697 RVA: 0x00DE7A3F File Offset: 0x00DE5C3F
		[NullableContext(2)]
		public TPendingProcess GetCurrentProcess()
		{
			return this.CurProcess;
		}

		// Token: 0x0401A533 RID: 107827
		[CompilerGenerated]
		private Func<bool> <checkDeleteSameTreeHandle>P = checkDeleteSameTreeHandle;

		// Token: 0x0401A534 RID: 107828
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<MissionItemViewStartTrackProcess, UniTask<bool>> <missionItemViewStartTrackHandle>P = missionItemViewStartTrackHandle;

		// Token: 0x0401A535 RID: 107829
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<MissionItemViewEndTrackProcess, UniTask<bool>> <missionItemViewEndTrackHandle>P = missionItemViewEndTrackHandle;

		// Token: 0x0401A536 RID: 107830
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<MissionItemViewRefreshProcess, UniTask<bool>> <missionItemViewRefreshHandle>P = missionItemViewRefreshHandle;

		// Token: 0x0401A537 RID: 107831
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<ShowQuestUpdateTipsProcess, UniTask<bool>> <showQuestUpdateTipsHandle>P = showQuestUpdateTipsHandle;

		// Token: 0x0401A538 RID: 107832
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[CompilerGenerated]
		private Func<StepConditionIndexChangeProcess, UniTask<bool>> <stepConditionIndexChange>P = stepConditionIndexChange;

		// Token: 0x0401A539 RID: 107833
		private readonly List<TPendingProcess> ProcessQueue = new List<TPendingProcess>();

		// Token: 0x0401A53A RID: 107834
		private readonly Queue<TPendingProcess> AddToFirstProcessQueue = new Queue<TPendingProcess>(4);

		// Token: 0x0401A53B RID: 107835
		[Nullable(2)]
		private TPendingProcess CurProcess;

		// Token: 0x0401A53C RID: 107836
		private int FishingEntrustViewShowId;
	}
}
