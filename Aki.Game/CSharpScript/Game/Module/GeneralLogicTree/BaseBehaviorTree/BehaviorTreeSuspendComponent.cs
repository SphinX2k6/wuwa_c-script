using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree
{
	// Token: 0x020049C3 RID: 18883
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorTreeSuspendComponent
	{
		// Token: 0x0602F46A RID: 193642 RVA: 0x00D2F799 File Offset: 0x00D2D999
		public BehaviorTreeSuspendComponent(long treeIncId, Blackboard blackBoard)
		{
			this.Blackboard = blackBoard;
			this.TreeIncId = treeIncId;
		}

		// Token: 0x0602F46B RID: 193643 RVA: 0x00D2F7BC File Offset: 0x00D2D9BC
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

		// Token: 0x0602F46C RID: 193644 RVA: 0x00D2F808 File Offset: 0x00D2DA08
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

		// Token: 0x0602F46D RID: 193645 RVA: 0x00D2F86A File Offset: 0x00D2DA6A
		public IReadOnlyList<IOccupationInfo> GetOccupations()
		{
			return this.Occupations;
		}

		// Token: 0x0602F46E RID: 193646 RVA: 0x00D2F874 File Offset: 0x00D2DA74
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

		// Token: 0x0602F46F RID: 193647 RVA: 0x00D2F8CC File Offset: 0x00D2DACC
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

		// Token: 0x0602F470 RID: 193648 RVA: 0x00D2FA04 File Offset: 0x00D2DC04
		public void ClearOccupations()
		{
			this.Occupations.Clear();
			this.Blackboard.RemoveTag(EBehaviorTreeTag.Suspending, "");
			this.Blackboard.RemoveTag(EBehaviorTreeTag.SuspendingCanShow, "");
			EventSystem.Instance.Emit<long>(EEventName.GeneralLogicTreeCancelSuspend, this.TreeIncId);
			EventSystem.Instance.EmitWithTarget<long>(this.Blackboard, EEventName.GeneralLogicTreeCancelSuspend, this.TreeIncId);
		}

		// Token: 0x04019137 RID: 102711
		private readonly long TreeIncId;

		// Token: 0x04019138 RID: 102712
		private readonly Blackboard Blackboard;

		// Token: 0x04019139 RID: 102713
		private List<IOccupationInfo> Occupations = new List<IOccupationInfo>();

		// Token: 0x0401913A RID: 102714
		private EBehaviorTreeSuspendType CurSuspendState;
	}
}
