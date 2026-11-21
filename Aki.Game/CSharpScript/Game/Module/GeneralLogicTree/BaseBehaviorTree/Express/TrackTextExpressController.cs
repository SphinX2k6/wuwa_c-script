using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express
{
	// Token: 0x020049CA RID: 18890
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackTextExpressController
	{
		// Token: 0x0602F4DA RID: 193754 RVA: 0x00D31E84 File Offset: 0x00D30084
		public TrackTextExpressController(Blackboard blackboard)
		{
			this.Blackboard = blackboard;
			this.UiBlackBoardTrackTextInfo = blackboard.UiTrackTextInfo;
		}

		// Token: 0x0602F4DB RID: 193755 RVA: 0x00D31EC0 File Offset: 0x00D300C0
		public void Clear()
		{
			this.UiCustomTrackTextInfo.Clear();
			this.UiBlackBoardTrackTextInfo.Clear();
			this.CustomUiConfigs.Clear();
			this.TextExpressUse.Clear();
			LevelPlayModel.Instance.ChangeLevelPlayTrackRange(this.Blackboard.TreeConfigId, null);
			this.EndTextExpress(ETreeTextExpressReason.None);
		}

		// Token: 0x0602F4DC RID: 193756 RVA: 0x00D31F20 File Offset: 0x00D30120
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

		// Token: 0x0602F4DD RID: 193757 RVA: 0x00D31F47 File Offset: 0x00D30147
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

		// Token: 0x0602F4DE RID: 193758 RVA: 0x00D31F7C File Offset: 0x00D3017C
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

		// Token: 0x0602F4DF RID: 193759 RVA: 0x00D31FE5 File Offset: 0x00D301E5
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

		// Token: 0x0602F4E0 RID: 193760 RVA: 0x00D3201C File Offset: 0x00D3021C
		public void UpdateOnNodeStatusChange(BehaviorNodeBase node, NodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			this.UpdateTrackTextData(node, newStatus);
			bool bSentUpdateTips = this.SendUpdateTips(node, newStatus, reason);
			this.UpdateTextExpress(bSentUpdateTips);
		}

		// Token: 0x0602F4E1 RID: 193761 RVA: 0x00D32042 File Offset: 0x00D30242
		public void UpdateTextDataOnly()
		{
			this.SetCommonTextData();
		}

		// Token: 0x0602F4E2 RID: 193762 RVA: 0x00D3204A File Offset: 0x00D3024A
		public void OnBtApplyExpressionOccupation(bool bSelf)
		{
			if (bSelf)
			{
				return;
			}
			this.EndShowTextImp(ETreeTextExpressReason.TextOccupation);
		}

		// Token: 0x0602F4E3 RID: 193763 RVA: 0x00D32057 File Offset: 0x00D30257
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

		// Token: 0x0602F4E4 RID: 193764 RVA: 0x00D32071 File Offset: 0x00D30271
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

		// Token: 0x0602F4E5 RID: 193765 RVA: 0x00D3208C File Offset: 0x00D3028C
		public void OnCancelSuspend()
		{
			this.ProcessChallengeUi();
			if (this.TextExpressUse.Count != 0)
			{
				this.StartShowTextImp(ETreeTextExpressReason.TextOccupation);
			}
		}

		// Token: 0x0602F4E6 RID: 193766 RVA: 0x00D320A8 File Offset: 0x00D302A8
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

		// Token: 0x0602F4E7 RID: 193767 RVA: 0x00D32148 File Offset: 0x00D30348
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

		// Token: 0x0602F4E8 RID: 193768 RVA: 0x00D321A0 File Offset: 0x00D303A0
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

		// Token: 0x0602F4E9 RID: 193769 RVA: 0x00D321C8 File Offset: 0x00D303C8
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

		// Token: 0x0602F4EA RID: 193770 RVA: 0x00D32294 File Offset: 0x00D30494
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

		// Token: 0x0602F4EB RID: 193771 RVA: 0x00D3230C File Offset: 0x00D3050C
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

		// Token: 0x0602F4EC RID: 193772 RVA: 0x00D32468 File Offset: 0x00D30668
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

		// Token: 0x0602F4ED RID: 193773 RVA: 0x00D325A4 File Offset: 0x00D307A4
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

		// Token: 0x0602F4EE RID: 193774 RVA: 0x00D32620 File Offset: 0x00D30820
		private void ProcessChallengeUi()
		{
			if (!this.Blackboard.ContainTag(EBehaviorTreeTag.CustomUi))
			{
				return;
			}
			this.UiBlackBoardTrackTextInfo.Clear();
			this.UiBlackBoardTrackTextInfo.CopyConfig(this.UiCustomTrackTextInfo);
		}

		// Token: 0x0401915C RID: 102748
		private readonly Blackboard Blackboard;

		// Token: 0x0401915D RID: 102749
		private readonly TreeTrackTextExpressionInfo UiBlackBoardTrackTextInfo;

		// Token: 0x0401915E RID: 102750
		private readonly TreeTrackTextExpressionInfo UiCustomTrackTextInfo = new TreeTrackTextExpressionInfo();

		// Token: 0x0401915F RID: 102751
		private readonly Dictionary<int, bool> TextExpressUse = new Dictionary<int, bool>();

		// Token: 0x04019160 RID: 102752
		private readonly List<BtCustomUiConfig> CustomUiConfigs = new List<BtCustomUiConfig>();

		// Token: 0x04019161 RID: 102753
		private bool TextExpressing;

		// Token: 0x04019162 RID: 102754
		[Nullable(2)]
		private TimerHandle UpdateTrackTextTimerHandle;
	}
}
