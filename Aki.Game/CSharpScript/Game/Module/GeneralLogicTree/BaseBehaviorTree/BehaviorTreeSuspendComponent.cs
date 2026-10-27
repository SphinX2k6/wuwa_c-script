using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree
{
	// Token: 0x020059EA RID: 23018
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorTreeSuspendComponent
	{
		// Token: 0x0603A543 RID: 238915 RVA: 0x00DDFF2D File Offset: 0x00DDE12D
		public BehaviorTreeSuspendComponent(long treeIncId, Blackboard blackBoard)
		{
			this.Blackboard = blackBoard;
			this.TreeIncId = treeIncId;
		}

		// Token: 0x0603A544 RID: 238916 RVA: 0x00DDFF50 File Offset: 0x00DDE150
		public EBehaviorTreeSuspendType GetSuspendType()
		{
			if (this.CurSuspendState == EBehaviorTreeSuspendType.None)
			{
				return EBehaviorTreeSuspendType.None;
			}
			if (this.CurSuspendState.HasFlag(EBehaviorTreeSuspendType.Online))
			{
				return EBehaviorTreeSuspendType.Online;
			}
			if (this.CurSuspendState.HasFlag(EBehaviorTreeSuspendType.Occupation))
			{
				return EBehaviorTreeSuspendType.Occupation;
			}
			return EBehaviorTreeSuspendType.None;
		}

		// Token: 0x0603A545 RID: 238917 RVA: 0x00DDFF9C File Offset: 0x00DDE19C
		[NullableContext(2)]
		public string GetSuspendText()
		{
			if (!this.Blackboard.IsSuspend())
			{
				return null;
			}
			string result = null;
			EBehaviorTreeSuspendType suspendType = this.GetSuspendType();
			if (suspendType != EBehaviorTreeSuspendType.Occupation)
			{
				if (suspendType == EBehaviorTreeSuspendType.Online)
				{
					result = TextConfig.Instance.GetTextById("SuspendByOnline");
				}
			}
			else if (this.Occupations.Count != 0)
			{
				result = this.ConvertOccupationToTipString(this.Occupations[0]);
			}
			return result;
		}

		// Token: 0x0603A546 RID: 238918 RVA: 0x00DDFFFE File Offset: 0x00DDE1FE
		public IReadOnlyList<IOccupationInfo> GetOccupations()
		{
			return this.Occupations;
		}

		// Token: 0x0603A547 RID: 238919 RVA: 0x00DE0008 File Offset: 0x00DDE208
		private string ConvertOccupationToTipString(IOccupationInfo occupation)
		{
			string textById = TextConfig.Instance.GetTextById("QuestResourcesIsOccupied");
			TArray<string> tarray = new TArray<string>();
			string occupationResourceName = QuestNewConfig.Instance.GetOccupationResourceName(occupation.ResourceName);
			string behaviorTreeName = GeneralLogicTreeModel.Instance.GetBehaviorTreeName(occupation.TreeIncId);
			tarray.Add(occupationResourceName);
			tarray.Add(behaviorTreeName);
			return UKuroStaticLibrary.KuroFormatText(textById, tarray);
		}

		// Token: 0x0603A548 RID: 238920 RVA: 0x00DE0060 File Offset: 0x00DDE260
		public void UpdateOccupations(int nodeId, int curSuspendState, IReadOnlyList<OccupationPbInfo> occupationInfos)
		{
			this.CurSuspendState = (EBehaviorTreeSuspendType)curSuspendState;
			if (curSuspendState == 0)
			{
				this.ClearOccupations();
				return;
			}
			this.Blackboard.RemoveTag(EBehaviorTreeTag.Suspending, "");
			this.Occupations.Clear();
			foreach (OccupationPbInfo occupationPbInfo in occupationInfos)
			{
				long incId = occupationPbInfo.IncId;
				BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(incId), false);
				string questName = "";
				if (behaviorTree != null)
				{
					questName = GeneralLogicTreeUtil.Instance.GetLogicTreeContainer(behaviorTree.BtType, behaviorTree.TreeConfigId).Name;
				}
				this.Occupations.Add(new IOccupationInfo
				{
					ResourceName = occupationPbInfo.ResourceName,
					QuestName = questName,
					TreeIncId = occupationPbInfo.IncId
				});
			}
			this.Blackboard.AddTag(EBehaviorTreeTag.Suspending, "");
			EBehaviorTreeSuspendType suspendType = this.GetSuspendType();
			EventSystem.Instance.Emit<long, int, EBehaviorTreeSuspendType>(EEventName.GeneralLogicTreeSuspend, this.TreeIncId, nodeId, suspendType);
			EventSystem.Instance.EmitWithTarget<long, int, EBehaviorTreeSuspendType>(this.Blackboard, EEventName.GeneralLogicTreeSuspend, this.TreeIncId, nodeId, suspendType);
		}

		// Token: 0x0603A549 RID: 238921 RVA: 0x00DE0198 File Offset: 0x00DDE398
		public void ClearOccupations()
		{
			this.Occupations.Clear();
			this.Blackboard.RemoveTag(EBehaviorTreeTag.Suspending, "");
			this.Blackboard.RemoveTag(EBehaviorTreeTag.SuspendingCanShow, "");
			EventSystem.Instance.Emit<long>(EEventName.GeneralLogicTreeCancelSuspend, this.TreeIncId);
			EventSystem.Instance.EmitWithTarget<long>(this.Blackboard, EEventName.GeneralLogicTreeCancelSuspend, this.TreeIncId);
		}

		// Token: 0x0401E698 RID: 124568
		private readonly long TreeIncId;

		// Token: 0x0401E699 RID: 124569
		private readonly Blackboard Blackboard;

		// Token: 0x0401E69A RID: 124570
		private List<IOccupationInfo> Occupations = new List<IOccupationInfo>();

		// Token: 0x0401E69B RID: 124571
		private EBehaviorTreeSuspendType CurSuspendState;
	}
}
