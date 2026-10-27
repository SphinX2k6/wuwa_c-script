using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007323 RID: 29475
	[NullableContext(2)]
	[Nullable(0)]
	public class AiStateMachineState
	{
		// Token: 0x06048597 RID: 296343 RVA: 0x0129C5DB File Offset: 0x0129A7DB
		[NullableContext(1)]
		public AiStateMachineState(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state)
		{
			this.Node = stateMachineNode;
			this.StateData = state;
		}

		// Token: 0x06048598 RID: 296344 RVA: 0x0129C5F1 File Offset: 0x0129A7F1
		public bool Init()
		{
			return this.OnInit(this.StateData);
		}

		// Token: 0x06048599 RID: 296345 RVA: 0x0129C5FF File Offset: 0x0129A7FF
		[NullableContext(1)]
		protected virtual bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			return true;
		}

		// Token: 0x0604859A RID: 296346 RVA: 0x0129C602 File Offset: 0x0129A802
		public virtual void OnEnter(AiStateMachineBase lastState = null, long? contextId = null)
		{
		}

		// Token: 0x0604859B RID: 296347 RVA: 0x0129C604 File Offset: 0x0129A804
		public virtual void OnExit(AiStateMachineBase nextState = null, long? contextId = null)
		{
		}

		// Token: 0x0604859C RID: 296348 RVA: 0x0129C606 File Offset: 0x0129A806
		public virtual void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
		}

		// Token: 0x0604859D RID: 296349 RVA: 0x0129C608 File Offset: 0x0129A808
		public virtual void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
		}

		// Token: 0x0604859E RID: 296350 RVA: 0x0129C60A File Offset: 0x0129A80A
		public virtual void OnExecuted(long? contextId = null)
		{
		}

		// Token: 0x0604859F RID: 296351 RVA: 0x0129C60C File Offset: 0x0129A80C
		public virtual void Tick(float deltaSeconds, long? contextId = null)
		{
			this.OnTick(deltaSeconds, contextId);
		}

		// Token: 0x060485A0 RID: 296352 RVA: 0x0129C616 File Offset: 0x0129A816
		protected virtual void OnTick(float deltaSeconds, long? contextId = null)
		{
		}

		// Token: 0x060485A1 RID: 296353 RVA: 0x0129C618 File Offset: 0x0129A818
		public void Clear()
		{
			this.OnClear();
			this.Node = null;
		}

		// Token: 0x060485A2 RID: 296354 RVA: 0x0129C627 File Offset: 0x0129A827
		protected virtual void OnClear()
		{
		}

		// Token: 0x060485A3 RID: 296355 RVA: 0x0129C629 File Offset: 0x0129A829
		[NullableContext(1)]
		public virtual void ToString(StringBuilder outBuilder, int depth = 0)
		{
		}

		// Token: 0x04026412 RID: 156690
		public AiStateMachineBase Node;

		// Token: 0x04026413 RID: 156691
		public readonly CombatStateMachineDefine.Fsm.State StateData;
	}
}
