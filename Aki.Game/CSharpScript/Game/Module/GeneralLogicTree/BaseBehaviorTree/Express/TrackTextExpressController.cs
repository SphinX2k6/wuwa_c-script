using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express
{
	// Token: 0x020059F0 RID: 23024
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackTextExpressController
	{
		// Token: 0x0603A5A9 RID: 239017 RVA: 0x00DE2571 File Offset: 0x00DE0771
		public TrackTextExpressController(Blackboard blackboard)
		{
			this.Blackboard = blackboard;
			this.UiBlackBoardTrackTextInfo = blackboard.UiTrackTextInfo;
		}

		// Token: 0x0603A5AA RID: 239018 RVA: 0x00DE25B0 File Offset: 0x00DE07B0
		public void Clear()
		{
			this.UiCustomTrackTextInfo.Clear();
			this.UiBlackBoardTrackTextInfo.Clear();
			this.CustomUiConfigs.Clear();
			this.TextExpressUse.Clear();
			LevelPlayModel.Instance.ChangeLevelPlayTrackRange(this.Blackboard.TreeConfigId, null);
			this.EndTextExpress(ETreeTextExpressReason.None);
		}

		// Token: 0x0603A5AB RID: 239019 RVA: 0x00DE2610 File Offset: 0x00DE0810
		public void EnableTrack(bool value, ESetTrackReason reason = ESetTrackReason.None)
		{
			if (value)
			{
				this.StartTextExpress(ETreeTextExpressReason.None);
				return;
			}
			ETreeTextExpressReason reason2 = ETreeTextExpressReason.None;
			if (reason == ESetTrackReason.QuestFinished)
			{
				reason2 = ETreeTextExpressReason.QuestFinished;
			}
			this.EndTextExpress(reason2);
		}

		// Token: 0x0603A5AC RID: 239020 RVA: 0x00DE2637 File Offset: 0x00DE0837
		public void StartTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
		{
			this.TextExpressUse[(int)reason] = true;
			if (this.Blackboard.IsOccupied)
			{
				return;
			}
			if (this.Blackboard.IsTrackBoundToParent)
			{
				return;
			}
			this.StartShowTextImp(reason);
		}

		// Token: 0x0603A5AD RID: 239021 RVA: 0x00DE266C File Offset: 0x00DE086C
		private void StartShowTextImp(ETreeTextExpressReason reason)
		{
			if (this.Blackboard.IsTrackBoundToParent)
			{
				return;
			}
			if (this.TextExpressing)
			{
				return;
			}
			bool p = this.Blackboard.ContainTag(EBehaviorTreeTag.SkipMissionPanelAnim) || AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled;
			EventSystem.Instance.Emit<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeStartShowTrackText, this.Blackboard.CreateShowData(true), reason, p);
			this.TextExpressing = true;
		}

		// Token: 0x0603A5AE RID: 239022 RVA: 0x00DE26D5 File Offset: 0x00DE08D5
		public void EndTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
		{
			if (reason == ETreeTextExpressReason.QuestFinished)
			{
				this.TextExpressUse.Clear();
			}
			else
			{
				this.TextExpressUse.Remove((int)reason);
			}
			if (this.TextExpressUse.Count != 0)
			{
				return;
			}
			this.EndShowTextImp(reason);
		}

		// Token: 0x0603A5AF RID: 239023 RVA: 0x00DE270C File Offset: 0x00DE090C
		public void UpdateOnNodeStatusChange(BehaviorNodeBase node, NodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			this.UpdateTrackTextData(node, newStatus);
			bool bSentUpdateTips = this.SendUpdateTips(node, newStatus, reason);
			this.UpdateTextExpress(bSentUpdateTips);
		}

		// Token: 0x0603A5B0 RID: 239024 RVA: 0x00DE2732 File Offset: 0x00DE0932
		public void UpdateTextDataOnly()
		{
			this.SetCommonTextData();
		}

		// Token: 0x0603A5B1 RID: 239025 RVA: 0x00DE273A File Offset: 0x00DE093A
		public void OnBtApplyExpressionOccupation(bool bSelf)
		{
			if (bSelf)
			{
				return;
			}
			this.EndShowTextImp(ETreeTextExpressReason.TextOccupation);
		}

		// Token: 0x0603A5B2 RID: 239026 RVA: 0x00DE2747 File Offset: 0x00DE0947
		public void OnBtReleaseExpressionOccupation(bool bSelf)
		{
			if (bSelf)
			{
				return;
			}
			if (this.TextExpressUse.Count != 0)
			{
				this.StartShowTextImp(ETreeTextExpressReason.TextOccupation);
			}
		}

		// Token: 0x0603A5B3 RID: 239027 RVA: 0x00DE2761 File Offset: 0x00DE0961
		public void OnSuspend(int nodeId, EBehaviorTreeSuspendType suspendType)
		{
			if (suspendType == EBehaviorTreeSuspendType.Occupation)
			{
				this.UpdateSuspendTrackTextData(nodeId, suspendType);
				return;
			}
			if (suspendType != EBehaviorTreeSuspendType.Online)
			{
				return;
			}
			this.EndShowTextImp(ETreeTextExpressReason.Online);
		}

		// Token: 0x0603A5B4 RID: 239028 RVA: 0x00DE277C File Offset: 0x00DE097C
		public void OnCancelSuspend()
		{
			this.ProcessChallengeUi();
			if (this.TextExpressUse.Count != 0)
			{
				this.StartShowTextImp(ETreeTextExpressReason.TextOccupation);
			}
		}

		// Token: 0x0603A5B5 RID: 239029 RVA: 0x00DE2798 File Offset: 0x00DE0998
		private void EndShowTextImp(ETreeTextExpressReason reason)
		{
			if (this.Blackboard.IsTrackBoundToParent)
			{
				return;
			}
			if (!this.TextExpressing)
			{
				return;
			}
			bool p = this.Blackboard.ContainTag(EBehaviorTreeTag.SkipMissionPanelAnim) || AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled;
			EventSystem.Instance.Emit<long, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeEndShowTrackText, this.Blackboard.TreeIncId, reason, p);
			GeneralLogicTreeController.Instance.TryReleaseExpressionOccupation(this.Blackboard.TreeIncId);
			this.TextExpressing = false;
			if (TimerSystem.Instance.Has(this.UpdateTrackTextTimerHandle))
			{
				TimerSystem.Instance.Remove(this.UpdateTrackTextTimerHandle);
			}
		}

		// Token: 0x0603A5B6 RID: 239030 RVA: 0x00DE2838 File Offset: 0x00DE0A38
		private void UpdateTextExpress(bool bSentUpdateTips)
		{
			if (this.Blackboard.IsTrackBoundToParent)
			{
				return;
			}
			if (!this.TextExpressing || bSentUpdateTips)
			{
				return;
			}
			if (TimerSystem.Instance.Has(this.UpdateTrackTextTimerHandle))
			{
				TimerSystem.Instance.Remove(this.UpdateTrackTextTimerHandle);
			}
			this.UpdateTrackTextTimerHandle = this.DoDelayUpdate();
		}

		// Token: 0x0603A5B7 RID: 239031 RVA: 0x00DE2890 File Offset: 0x00DE0A90
		[NullableContext(2)]
		private TimerHandle DoDelayUpdate()
		{
			return TimerSystem.Instance.Delay(delegate(float _)
			{
				if (this.TextExpressing)
				{
					bool p = this.Blackboard.ContainTag(EBehaviorTreeTag.SkipMissionPanelAnim) || AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled;
					EventSystem.Instance.Emit<BehaviorTreeViewShowData, bool>(EEventName.GeneralLogicTreeUpdateShowTrackText, this.Blackboard.CreateShowData(true), p);
				}
			}, 100f, null, null, true, 1f);
		}

		// Token: 0x0603A5B8 RID: 239032 RVA: 0x00DE28B8 File Offset: 0x00DE0AB8
		private bool SendUpdateTips(BehaviorNodeBase node, NodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			if (reason != ENodeStatusUpdateReason.ServerUpdateNodeStatus || newStatus != NodeStatus.Activated || (this.Blackboard.BtType != BtType.Quest && this.Blackboard.BtType != BtType.Recall))
			{
				return false;
			}
			global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
			int? num = (curTrackedQuest != null) ? new int?(curTrackedQuest.Id) : null;
			int treeConfigId = this.Blackboard.TreeConfigId;
			int? num2 = num;
			if (treeConfigId == num2.GetValueOrDefault() & num2 != null)
			{
				return false;
			}
			if (!node.ContainTag(EBehaviorTreeTag.CanShow) || node.ContainTag(EBehaviorTreeTag.HideQuestUpdateTips))
			{
				return false;
			}
			if (string.IsNullOrEmpty(GeneralLogicTreeController.Instance.GetNodeTrackText(this.Blackboard.TreeIncId, node.NodeId)))
			{
				return false;
			}
			GeneralLogicTreeModel.Instance.SaveUpdateInfo(this.Blackboard.TreeIncId, node.NodeId);
			return true;
		}

		// Token: 0x0603A5B9 RID: 239033 RVA: 0x00DE2984 File Offset: 0x00DE0B84
		private void UpdateTrackTextData(BehaviorNodeBase node, NodeStatus newStatus)
		{
			LogicNodeBase logicNodeBase = node as LogicNodeBase;
			if (logicNodeBase != null)
			{
				switch (newStatus)
				{
				case NodeStatus.Activated:
					if (logicNodeBase.ContainTag(EBehaviorTreeTag.CanShow))
					{
						this.SetCustomUiConfig(logicNodeBase.NodeId, logicNodeBase.CustomUiConfig);
						return;
					}
					break;
				case NodeStatus.Completing:
				case NodeStatus.Suspend:
					break;
				case NodeStatus.CompletedSuccess:
				case NodeStatus.CompletedFailed:
				case NodeStatus.Destroy:
					this.SetCustomUiConfig(logicNodeBase.NodeId, null);
					break;
				default:
					return;
				}
				return;
			}
			if (this.Blackboard.ContainTag(EBehaviorTreeTag.CustomUi))
			{
				return;
			}
			this.SetCommonTextData();
		}

		// Token: 0x0603A5BA RID: 239034 RVA: 0x00DE29FC File Offset: 0x00DE0BFC
		[NullableContext(2)]
		private void SetCustomUiConfig(int nodeId, IQuestScheduleConfig config)
		{
			int num = this.CustomUiConfigs.FindIndex((BtCustomUiConfig value) => value.SourceOfAdd == nodeId);
			if (config != null)
			{
				if (num < 0)
				{
					this.CustomUiConfigs.Add(new BtCustomUiConfig(nodeId, config));
				}
				else
				{
					this.CustomUiConfigs[num].CustomUiConfig = config;
				}
			}
			else
			{
				if (num < 0)
				{
					return;
				}
				this.CustomUiConfigs.RemoveAt(num);
			}
			this.Blackboard.RemoveTag(EBehaviorTreeTag.CustomUi, "");
			this.Blackboard.RemoveTag(EBehaviorTreeTag.ChallengeUi, "");
			int? trackRadius = null;
			if (this.CustomUiConfigs.Count != 0)
			{
				this.Blackboard.AddTag(EBehaviorTreeTag.CustomUi, "");
				List<BtCustomUiConfig> customUiConfigs = this.CustomUiConfigs;
				IQuestScheduleConfig customUiConfig = customUiConfigs[customUiConfigs.Count - 1].CustomUiConfig;
				this.UiCustomTrackTextInfo.CopyConfig(customUiConfig);
				ILevelPlayTrackRadius trackRadius2 = customUiConfig.TrackRadius;
				trackRadius = ((trackRadius2 != null) ? new int?(trackRadius2.TrackRadius) : null);
				if (customUiConfig.UiType == EQuestScheduleUiType.LevelPlay)
				{
					this.Blackboard.AddTag(EBehaviorTreeTag.ChallengeUi, "");
				}
				this.UiBlackBoardTrackTextInfo.Clear();
				this.UiBlackBoardTrackTextInfo.CopyConfig(customUiConfig);
			}
			else
			{
				this.SetCommonTextData();
			}
			LevelPlayModel.Instance.ChangeLevelPlayTrackRange(this.Blackboard.TreeConfigId, trackRadius);
		}

		// Token: 0x0603A5BB RID: 239035 RVA: 0x00DE2B58 File Offset: 0x00DE0D58
		private void SetCommonTextData()
		{
			this.UiBlackBoardTrackTextInfo.Clear();
			Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.Blackboard.GetNodesByGroupId(ENodeGroup.IsProcessing);
			if (nodesByGroupId == null)
			{
				return;
			}
			int num = 0;
			foreach (KeyValuePair<int, BehaviorNodeBase> keyValuePair in nodesByGroupId)
			{
				int num2;
				BehaviorNodeBase behaviorNodeBase;
				keyValuePair.Deconstruct(out num2, out behaviorNodeBase);
				int childQuestId = num2;
				BehaviorNodeBase behaviorNodeBase2 = behaviorNodeBase;
				if (behaviorNodeBase2.ContainTag(EBehaviorTreeTag.CanShow) && behaviorNodeBase2.TrackTextConfig != null)
				{
					this.UiBlackBoardTrackTextInfo.SetMainTitle(new IQuestScheduleMainTitle
					{
						TidTitle = behaviorNodeBase2.TrackTextConfig,
						QuestScheduleType = new IQuestScheduleChildQuestCompleted
						{
							Type = EQuestScheduleType.ChildQuestCompleted,
							ChildQuestId = childQuestId,
							ShowTracking = new bool?(true)
						}
					});
					this.UiBlackBoardTrackTextInfo.AddSubTitle(new IQuestScheduleSubTitle
					{
						TidTitle = behaviorNodeBase2.TrackTextConfig,
						QuestScheduleType = new IQuestScheduleChildQuestCompleted
						{
							Type = EQuestScheduleType.ChildQuestCompleted,
							ChildQuestId = childQuestId,
							ShowTracking = new bool?(true)
						}
					});
					num++;
				}
			}
			if (num == 1)
			{
				this.UiBlackBoardTrackTextInfo.ClearSubTitle();
				return;
			}
			this.UiBlackBoardTrackTextInfo.SetMainTitle(null);
		}

		// Token: 0x0603A5BC RID: 239036 RVA: 0x00DE2C94 File Offset: 0x00DE0E94
		private void UpdateSuspendTrackTextData(int nodeId, EBehaviorTreeSuspendType suspendType)
		{
			this.UiBlackBoardTrackTextInfo.Clear();
			if (suspendType == EBehaviorTreeSuspendType.Occupation && !StringUtils.IsBlank(PublicUtil.Instance.GetConfigTextByKey("TaskOccupyGeneralDes_1001")))
			{
				this.UiBlackBoardTrackTextInfo.SetMainTitle(new IQuestScheduleMainTitle
				{
					TidTitle = "TaskOccupyGeneralDes_1001",
					QuestScheduleType = new IQuestScheduleType
					{
						Type = EQuestScheduleType.None
					}
				});
				this.UiBlackBoardTrackTextInfo.ClearSubTitle();
				this.Blackboard.AddTag(EBehaviorTreeTag.SuspendingCanShow, "");
			}
		}

		// Token: 0x0603A5BD RID: 239037 RVA: 0x00DE2D10 File Offset: 0x00DE0F10
		private void ProcessChallengeUi()
		{
			if (!this.Blackboard.ContainTag(EBehaviorTreeTag.CustomUi))
			{
				return;
			}
			this.UiBlackBoardTrackTextInfo.Clear();
			this.UiBlackBoardTrackTextInfo.CopyConfig(this.UiCustomTrackTextInfo);
		}

		// Token: 0x0401E6BB RID: 124603
		private readonly Blackboard Blackboard;

		// Token: 0x0401E6BC RID: 124604
		private readonly TreeTrackTextExpressionInfo UiBlackBoardTrackTextInfo;

		// Token: 0x0401E6BD RID: 124605
		private readonly TreeTrackTextExpressionInfo UiCustomTrackTextInfo = new TreeTrackTextExpressionInfo();

		// Token: 0x0401E6BE RID: 124606
		private readonly Dictionary<int, bool> TextExpressUse = new Dictionary<int, bool>();

		// Token: 0x0401E6BF RID: 124607
		private readonly List<BtCustomUiConfig> CustomUiConfigs = new List<BtCustomUiConfig>();

		// Token: 0x0401E6C0 RID: 124608
		private bool TextExpressing;

		// Token: 0x0401E6C1 RID: 124609
		[Nullable(2)]
		private TimerHandle UpdateTrackTextTimerHandle;
	}
}
