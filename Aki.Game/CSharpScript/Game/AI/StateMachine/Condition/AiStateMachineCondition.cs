using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.Utils.CombatStateMachine;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064B6 RID: 25782
	[NullableContext(2)]
	[Nullable(0)]
	public class AiStateMachineCondition
	{
		// Token: 0x1700772E RID: 30510
		// (get) Token: 0x0603EA3A RID: 256570 RVA: 0x01240719 File Offset: 0x0123E919
		public bool Result
		{
			get
			{
				return this.ResultSelf == !this.Reverse;
			}
		}

		// Token: 0x0603EA3B RID: 256571 RVA: 0x0124072C File Offset: 0x0123E92C
		[NullableContext(1)]
		public AiStateMachineCondition(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index)
		{
			this.Node = transition.Node;
			this.Transition = transition;
			this.ConditionData = condition;
			this.Reverse = condition.Reverse;
			this.Index = new int?(index);
		}

		// Token: 0x0603EA3C RID: 256572 RVA: 0x01240766 File Offset: 0x0123E966
		public bool Init(AiStateMachineCondition parentCondition = null)
		{
			this.CheckForClient = this.ConditionData.IsClient.GetValueOrDefault();
			this.Inited = this.OnInit(this.ConditionData);
			this.ParentCondition = parentCondition;
			return this.Inited;
		}

		// Token: 0x0603EA3D RID: 256573 RVA: 0x0124079D File Offset: 0x0123E99D
		[NullableContext(1)]
		protected virtual bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			return true;
		}

		// Token: 0x0603EA3E RID: 256574 RVA: 0x012407A0 File Offset: 0x0123E9A0
		public void Enter()
		{
			this.LastResult = null;
			this.OnEnter();
		}

		// Token: 0x0603EA3F RID: 256575 RVA: 0x012407B4 File Offset: 0x0123E9B4
		protected virtual void OnEnter()
		{
		}

		// Token: 0x0603EA40 RID: 256576 RVA: 0x012407B6 File Offset: 0x0123E9B6
		public void Exit()
		{
			this.LastResult = null;
			this.OnExit();
		}

		// Token: 0x0603EA41 RID: 256577 RVA: 0x012407CA File Offset: 0x0123E9CA
		protected virtual void OnExit()
		{
		}

		// Token: 0x0603EA42 RID: 256578 RVA: 0x012407CC File Offset: 0x0123E9CC
		public void Tick()
		{
			this.OnTick();
			if (this.CanReqFsmConditionPass())
			{
				this.ReqFsmConditionPass();
			}
			this.LastResult = new bool?(this.Result);
		}

		// Token: 0x0603EA43 RID: 256579 RVA: 0x012407F4 File Offset: 0x0123E9F4
		protected bool CanReqFsmConditionPass()
		{
			if (!this.Node.RootNode.IsAnimStateMachine && this.CheckForClient)
			{
				bool result = this.Result;
				bool? lastResult = this.LastResult;
				return !(result == lastResult.GetValueOrDefault() & lastResult != null);
			}
			return false;
		}

		// Token: 0x0603EA44 RID: 256580 RVA: 0x01240840 File Offset: 0x0123EA40
		protected void ReqFsmConditionPass()
		{
			FsmConditionPassPush fsmConditionPassPush = FsmConditionPassPush.Create();
			fsmConditionPassPush.FsmId = this.Node.RootNode.Uuid;
			fsmConditionPassPush.FromState = this.Transition.From;
			fsmConditionPassPush.ToState = this.Transition.To;
			fsmConditionPassPush.ConditionIndex = this.Index.Value;
			fsmConditionPassPush.Value = this.Result;
			CombatNet.Instance.Send(EPushMessageId.FsmConditionPassPush, this.Node.Entity, fsmConditionPassPush, null, null, null);
		}

		// Token: 0x0603EA45 RID: 256581 RVA: 0x012408DF File Offset: 0x0123EADF
		protected virtual void OnTick()
		{
		}

		// Token: 0x0603EA46 RID: 256582 RVA: 0x012408E1 File Offset: 0x0123EAE1
		public void Clear()
		{
			this.OnClear();
			this.Node = null;
			this.Transition = null;
			this.ConditionData = null;
			this.ParentCondition = null;
		}

		// Token: 0x0603EA47 RID: 256583 RVA: 0x01240905 File Offset: 0x0123EB05
		protected virtual void OnClear()
		{
		}

		// Token: 0x0603EA48 RID: 256584 RVA: 0x01240907 File Offset: 0x0123EB07
		[NullableContext(1)]
		public virtual void HandleServerDebugInfo(RepeatedField<bool> conditions)
		{
			this.ResultServer = conditions[this.Index.Value];
		}

		// Token: 0x0603EA49 RID: 256585 RVA: 0x01240920 File Offset: 0x0123EB20
		public virtual void OnSignaled()
		{
		}

		// Token: 0x0603EA4A RID: 256586 RVA: 0x01240924 File Offset: 0x0123EB24
		public void Signaled()
		{
			if (!CharacterStateMachineNewComponent.EventDrivenOn)
			{
				return;
			}
			if (!this.CheckForClient)
			{
				return;
			}
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
			AiStateMachineBase node = this.Node;
			Entity entity = (node != null) ? node.Entity : null;
			string message = "Signaled";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("condition", this.ConditionData.Name);
			instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.HasSignaled = true;
			if (this.CanReqFsmConditionPass())
			{
				this.ReqFsmConditionPass();
			}
			this.LastResult = new bool?(this.Result);
			if (this.ParentCondition != null)
			{
				this.ParentCondition.OnSignaled();
				return;
			}
			if (this.Result)
			{
				AiStateMachineBase node2 = this.Node;
				if (node2 == null)
				{
					return;
				}
				node2.TrySwitch(this.Transition.To);
			}
		}

		// Token: 0x0603EA4B RID: 256587 RVA: 0x012409E0 File Offset: 0x0123EBE0
		protected virtual bool RegisterEvents()
		{
			return CharacterStateMachineNewComponent.EventDrivenOn;
		}

		// Token: 0x0603EA4C RID: 256588 RVA: 0x012409E7 File Offset: 0x0123EBE7
		protected virtual bool UnregisterEvents()
		{
			return CharacterStateMachineNewComponent.EventDrivenOn;
		}

		// Token: 0x0603EA4D RID: 256589 RVA: 0x012409F0 File Offset: 0x0123EBF0
		[NullableContext(1)]
		public virtual void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("[");
			appendInterpolatedStringHandler.AppendFormatted(this.Result ? "Y" : "N");
			appendInterpolatedStringHandler.AppendLiteral(" ");
			outBuilder.Append(ref appendInterpolatedStringHandler);
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, outBuilder);
			appendInterpolatedStringHandler.AppendFormatted(this.ResultServer ? "Y" : "N");
			appendInterpolatedStringHandler.AppendLiteral(" ");
			outBuilder.Append(ref appendInterpolatedStringHandler);
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, outBuilder);
			appendInterpolatedStringHandler.AppendFormatted(this.CheckForClient ? "C" : "S");
			appendInterpolatedStringHandler.AppendLiteral("] ");
			outBuilder.Append(ref appendInterpolatedStringHandler);
			if (this.Reverse)
			{
				outBuilder.Append("[取反] ");
			}
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, outBuilder);
			appendInterpolatedStringHandler.AppendFormatted(this.ConditionData.Name);
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402172E RID: 137006
		protected bool Inited;

		// Token: 0x0402172F RID: 137007
		public AiStateMachineBase Node;

		// Token: 0x04021730 RID: 137008
		public AiStateMachineTransition Transition;

		// Token: 0x04021731 RID: 137009
		public AiStateMachineCondition ParentCondition;

		// Token: 0x04021732 RID: 137010
		public CombatStateMachineDefine.Fsm.Condition ConditionData;

		// Token: 0x04021733 RID: 137011
		public int? Index;

		// Token: 0x04021734 RID: 137012
		public bool CheckForClient;

		// Token: 0x04021735 RID: 137013
		public bool Reverse;

		// Token: 0x04021736 RID: 137014
		public bool ResultSelf;

		// Token: 0x04021737 RID: 137015
		public bool? LastResult;

		// Token: 0x04021738 RID: 137016
		public bool HasTaskFinishCondition;

		// Token: 0x04021739 RID: 137017
		public bool HasSignaled;

		// Token: 0x0402173A RID: 137018
		public bool ResultServer;
	}
}
