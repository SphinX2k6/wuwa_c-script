using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelFlow.Action;
using CSharpScript.Game.LevelFlow.Condition;

namespace CSharpScript.Game.LevelFlow.Node
{
	// Token: 0x020060F4 RID: 24820
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowNode : IStaticVariableResetter
	{
		// Token: 0x0603B82A RID: 243754 RVA: 0x010DE240 File Offset: 0x010DC440
		static LevelFlowNode()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowNode.CreateStaticDefaultValue), new Action(LevelFlowNode.ResetStaticDefaultValue));
		}

		// Token: 0x0603B82B RID: 243755 RVA: 0x010DE25F File Offset: 0x010DC45F
		public LevelFlowNode([Nullable(2)] LevelFlowConditionBase condition, List<LevelFlowActionBase> actionList)
		{
			this.NodeId = LevelFlowNode.SelfIncrementId++;
			this.Condition = condition;
			this.ActionList = actionList;
		}

		// Token: 0x0603B82C RID: 243756 RVA: 0x010DE29E File Offset: 0x010DC49E
		public void BindCompleteCallBack(Action<LevelFlowNode, bool> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x0603B82D RID: 243757 RVA: 0x010DE2A8 File Offset: 0x010DC4A8
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

		// Token: 0x0603B82E RID: 243758 RVA: 0x010DE2F4 File Offset: 0x010DC4F4
		public void Exit()
		{
			this.CompleteCallBack = null;
		}

		// Token: 0x0603B82F RID: 243759 RVA: 0x010DE300 File Offset: 0x010DC500
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

		// Token: 0x0603B830 RID: 243760 RVA: 0x010DE370 File Offset: 0x010DC570
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

		// Token: 0x0603B831 RID: 243761 RVA: 0x010DE3F4 File Offset: 0x010DC5F4
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

		// Token: 0x0603B832 RID: 243762 RVA: 0x010DE4AC File Offset: 0x010DC6AC
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

		// Token: 0x0603B833 RID: 243763 RVA: 0x010DE4D8 File Offset: 0x010DC6D8
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

		// Token: 0x170070AD RID: 28845
		// (get) Token: 0x0603B834 RID: 243764 RVA: 0x010DE535 File Offset: 0x010DC735
		public ELevelFlowNodeState NodeState
		{
			get
			{
				return this.NodeStateInternal;
			}
		}

		// Token: 0x0603B835 RID: 243765 RVA: 0x010DE53D File Offset: 0x010DC73D
		public static void CreateStaticDefaultValue()
		{
			LevelFlowNode.SelfIncrementId = 0;
		}

		// Token: 0x0603B836 RID: 243766 RVA: 0x010DE545 File Offset: 0x010DC745
		public static void ResetStaticDefaultValue()
		{
			LevelFlowNode.SelfIncrementId = 0;
		}

		// Token: 0x0401F632 RID: 128562
		public readonly int NodeId;

		// Token: 0x0401F633 RID: 128563
		private static int SelfIncrementId;

		// Token: 0x0401F634 RID: 128564
		private ELevelFlowNodeState NodeStateInternal;

		// Token: 0x0401F635 RID: 128565
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<LevelFlowNode, bool> CompleteCallBack;

		// Token: 0x0401F636 RID: 128566
		[Nullable(2)]
		private readonly LevelFlowConditionBase Condition;

		// Token: 0x0401F637 RID: 128567
		private readonly List<LevelFlowActionBase> ActionList = new List<LevelFlowActionBase>();

		// Token: 0x0401F638 RID: 128568
		private readonly HashSet<LevelFlowActionBase> ActionSet = new HashSet<LevelFlowActionBase>();
	}
}
