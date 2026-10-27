using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelFlow.Action;
using CSharpScript.Game.LevelFlow.Condition;

namespace CSharpScript.Game.LevelFlow.Node
{
	// Token: 0x02006F73 RID: 28531
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowNode : IStaticVariableResetter
	{
		// Token: 0x0604567C RID: 284284 RVA: 0x0113443C File Offset: 0x0113263C
		static LevelFlowNode()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowNode.CreateStaticDefaultValue), new Action(LevelFlowNode.ResetStaticDefaultValue));
		}

		// Token: 0x0604567D RID: 284285 RVA: 0x0113445B File Offset: 0x0113265B
		public LevelFlowNode([Nullable(2)] LevelFlowConditionBase condition, List<LevelFlowActionBase> actionList)
		{
			this.NodeId = LevelFlowNode.SelfIncrementId++;
			this.Condition = condition;
			this.ActionList = actionList;
		}

		// Token: 0x0604567E RID: 284286 RVA: 0x0113449A File Offset: 0x0113269A
		public void BindCompleteCallBack(Action<LevelFlowNode, bool> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x0604567F RID: 284287 RVA: 0x011344A4 File Offset: 0x011326A4
		public void Enter()
		{
			if (this.Condition != null)
			{
				this.NodeStateInternal = ELevelFlowNodeState.WaitingCondition;
				this.Condition.BindCompleteCallBack(new Action<bool>(this.OnConditionComplete));
				this.Condition.Enter();
				return;
			}
			this.NodeStateInternal = ELevelFlowNodeState.RunningAction;
			this.ExecuteActionList();
		}

		// Token: 0x06045680 RID: 284288 RVA: 0x011344F0 File Offset: 0x011326F0
		public void Exit()
		{
			this.CompleteCallBack = null;
		}

		// Token: 0x06045681 RID: 284289 RVA: 0x011344FC File Offset: 0x011326FC
		public void Tick(float deltaTime)
		{
			if (this.NodeState == ELevelFlowNodeState.WaitingCondition)
			{
				this.Condition.Tick(deltaTime);
				return;
			}
			if (this.NodeState == ELevelFlowNodeState.RunningAction)
			{
				foreach (LevelFlowActionBase levelFlowActionBase in this.ActionSet)
				{
					levelFlowActionBase.Tick(deltaTime);
				}
			}
		}

		// Token: 0x06045682 RID: 284290 RVA: 0x0113456C File Offset: 0x0113276C
		public void Reset()
		{
			if (this.NodeState == ELevelFlowNodeState.Idle)
			{
				return;
			}
			if (this.NodeState != ELevelFlowNodeState.WaitingCondition)
			{
				LevelFlowConditionBase condition = this.Condition;
				if (condition != null)
				{
					condition.Reset();
				}
				foreach (LevelFlowActionBase levelFlowActionBase in this.ActionList)
				{
					levelFlowActionBase.Reset();
				}
				return;
			}
			LevelFlowConditionBase condition2 = this.Condition;
			if (condition2 == null)
			{
				return;
			}
			condition2.Reset();
		}

		// Token: 0x06045683 RID: 284291 RVA: 0x011345F0 File Offset: 0x011327F0
		private void ExecuteActionList()
		{
			this.ActionSet.Clear();
			foreach (LevelFlowActionBase levelFlowActionBase in this.ActionList)
			{
				this.ActionSet.Add(levelFlowActionBase);
				levelFlowActionBase.BindCompleteCallBack(new Action<LevelFlowActionBase, bool>(this.OnActionComplete));
			}
			foreach (LevelFlowActionBase levelFlowActionBase2 in this.ActionList)
			{
				levelFlowActionBase2.Execute();
			}
		}

		// Token: 0x06045684 RID: 284292 RVA: 0x011346A8 File Offset: 0x011328A8
		private void OnConditionComplete(bool isSuccess)
		{
			if (isSuccess)
			{
				this.NodeStateInternal = ELevelFlowNodeState.RunningAction;
				this.ExecuteActionList();
				return;
			}
			this.NodeStateInternal = ELevelFlowNodeState.Failure;
			Action<LevelFlowNode, bool> completeCallBack = this.CompleteCallBack;
			if (completeCallBack == null)
			{
				return;
			}
			completeCallBack(this, false);
		}

		// Token: 0x06045685 RID: 284293 RVA: 0x011346D4 File Offset: 0x011328D4
		private void OnActionComplete(LevelFlowActionBase action, bool isSuccess)
		{
			if (isSuccess)
			{
				this.ActionSet.Remove(action);
				if (this.ActionSet.Count == 0)
				{
					this.NodeStateInternal = ELevelFlowNodeState.Success;
					Action<LevelFlowNode, bool> completeCallBack = this.CompleteCallBack;
					if (completeCallBack == null)
					{
						return;
					}
					completeCallBack(this, true);
					return;
				}
			}
			else
			{
				this.NodeStateInternal = ELevelFlowNodeState.Failure;
				Action<LevelFlowNode, bool> completeCallBack2 = this.CompleteCallBack;
				if (completeCallBack2 == null)
				{
					return;
				}
				completeCallBack2(this, false);
			}
		}

		// Token: 0x17009B6E RID: 39790
		// (get) Token: 0x06045686 RID: 284294 RVA: 0x01134731 File Offset: 0x01132931
		public ELevelFlowNodeState NodeState
		{
			get
			{
				return this.NodeStateInternal;
			}
		}

		// Token: 0x06045687 RID: 284295 RVA: 0x01134739 File Offset: 0x01132939
		public static void CreateStaticDefaultValue()
		{
			LevelFlowNode.SelfIncrementId = 0;
		}

		// Token: 0x06045688 RID: 284296 RVA: 0x01134741 File Offset: 0x01132941
		public static void ResetStaticDefaultValue()
		{
			LevelFlowNode.SelfIncrementId = 0;
		}

		// Token: 0x0402437D RID: 148349
		public readonly int NodeId;

		// Token: 0x0402437E RID: 148350
		private static int SelfIncrementId;

		// Token: 0x0402437F RID: 148351
		private ELevelFlowNodeState NodeStateInternal;

		// Token: 0x04024380 RID: 148352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<LevelFlowNode, bool> CompleteCallBack;

		// Token: 0x04024381 RID: 148353
		[Nullable(2)]
		private readonly LevelFlowConditionBase Condition;

		// Token: 0x04024382 RID: 148354
		private readonly List<LevelFlowActionBase> ActionList = new List<LevelFlowActionBase>();

		// Token: 0x04024383 RID: 148355
		private readonly HashSet<LevelFlowActionBase> ActionSet = new HashSet<LevelFlowActionBase>();
	}
}
