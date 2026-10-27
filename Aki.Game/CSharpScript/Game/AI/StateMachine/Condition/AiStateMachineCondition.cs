using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.Utils.CombatStateMachine;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007333 RID: 29491
	[NullableContext(2)]
	[Nullable(0)]
	public class AiStateMachineCondition
	{
		// Token: 0x17009F90 RID: 40848
		// (get) Token: 0x060485ED RID: 296429 RVA: 0x0129DC91 File Offset: 0x0129BE91
		public bool Result
		{
			get
			{
				return this.ResultSelf == !this.Reverse;
			}
		}

		// Token: 0x060485EE RID: 296430 RVA: 0x0129DCA4 File Offset: 0x0129BEA4
		[NullableContext(1)]
		public AiStateMachineCondition(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index)
		{
			this.Node = transition.Node;
			this.Transition = transition;
			this.ConditionData = condition;
			this.Reverse = condition.Reverse;
			this.Index = new int?(index);
		}

		// Token: 0x060485EF RID: 296431 RVA: 0x0129DCDE File Offset: 0x0129BEDE
		public bool Init(AiStateMachineCondition parentCondition = null)
		{
			this.CheckForClient = this.ConditionData.IsClient.GetValueOrDefault();
			this.Inited = this.OnInit(this.ConditionData);
			this.ParentCondition = parentCondition;
			return this.Inited;
		}

		// Token: 0x060485F0 RID: 296432 RVA: 0x0129DD15 File Offset: 0x0129BF15
		[NullableContext(1)]
		protected virtual bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			return true;
		}

		// Token: 0x060485F1 RID: 296433 RVA: 0x0129DD18 File Offset: 0x0129BF18
		public void Enter()
		{
			this.LastResult = null;
			this.OnEnter();
		}

		// Token: 0x060485F2 RID: 296434 RVA: 0x0129DD2C File Offset: 0x0129BF2C
		protected virtual void OnEnter()
		{
		}

		// Token: 0x060485F3 RID: 296435 RVA: 0x0129DD2E File Offset: 0x0129BF2E
		public void Exit()
		{
			this.LastResult = null;
			this.OnExit();
		}

		// Token: 0x060485F4 RID: 296436 RVA: 0x0129DD42 File Offset: 0x0129BF42
		protected virtual void OnExit()
		{
		}

		// Token: 0x060485F5 RID: 296437 RVA: 0x0129DD44 File Offset: 0x0129BF44
		public void Tick()
		{
			this.OnTick();
			if (this.CanReqFsmConditionPass())
			{
				this.ReqFsmConditionPass();
			}
			this.LastResult = new bool?(this.Result);
		}

		// Token: 0x060485F6 RID: 296438 RVA: 0x0129DD6C File Offset: 0x0129BF6C
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

		// Token: 0x060485F7 RID: 296439 RVA: 0x0129DDB8 File Offset: 0x0129BFB8
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

		// Token: 0x060485F8 RID: 296440 RVA: 0x0129DE57 File Offset: 0x0129C057
		protected virtual void OnTick()
		{
		}

		// Token: 0x060485F9 RID: 296441 RVA: 0x0129DE59 File Offset: 0x0129C059
		public void Clear()
		{
			this.OnClear();
			this.Node = null;
			this.Transition = null;
			this.ConditionData = null;
			this.ParentCondition = null;
		}

		// Token: 0x060485FA RID: 296442 RVA: 0x0129DE7D File Offset: 0x0129C07D
		protected virtual void OnClear()
		{
		}

		// Token: 0x060485FB RID: 296443 RVA: 0x0129DE7F File Offset: 0x0129C07F
		[NullableContext(1)]
		public virtual void HandleServerDebugInfo(RepeatedField<bool> conditions)
		{
			this.ResultServer = conditions[this.Index.Value];
		}

		// Token: 0x060485FC RID: 296444 RVA: 0x0129DE98 File Offset: 0x0129C098
		public virtual void OnSignaled()
		{
		}

		// Token: 0x060485FD RID: 296445 RVA: 0x0129DE9C File Offset: 0x0129C09C
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

		// Token: 0x060485FE RID: 296446 RVA: 0x0129DF58 File Offset: 0x0129C158
		protected virtual bool RegisterEvents()
		{
			return CharacterStateMachineNewComponent.EventDrivenOn;
		}

		// Token: 0x060485FF RID: 296447 RVA: 0x0129DF5F File Offset: 0x0129C15F
		protected virtual bool UnregisterEvents()
		{
			return CharacterStateMachineNewComponent.EventDrivenOn;
		}

		// Token: 0x06048600 RID: 296448 RVA: 0x0129DF68 File Offset: 0x0129C168
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

		// Token: 0x04026441 RID: 156737
		protected bool Inited;

		// Token: 0x04026442 RID: 156738
		public AiStateMachineBase Node;

		// Token: 0x04026443 RID: 156739
		public AiStateMachineTransition Transition;

		// Token: 0x04026444 RID: 156740
		public AiStateMachineCondition ParentCondition;

		// Token: 0x04026445 RID: 156741
		public CombatStateMachineDefine.Fsm.Condition ConditionData;

		// Token: 0x04026446 RID: 156742
		public int? Index;

		// Token: 0x04026447 RID: 156743
		public bool CheckForClient;

		// Token: 0x04026448 RID: 156744
		public bool Reverse;

		// Token: 0x04026449 RID: 156745
		public bool ResultSelf;

		// Token: 0x0402644A RID: 156746
		public bool? LastResult;

		// Token: 0x0402644B RID: 156747
		public bool HasTaskFinishCondition;

		// Token: 0x0402644C RID: 156748
		public bool HasSignaled;

		// Token: 0x0402644D RID: 156749
		public bool ResultServer;
	}
}
