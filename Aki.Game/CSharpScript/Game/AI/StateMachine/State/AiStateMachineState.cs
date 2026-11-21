using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064A6 RID: 25766
	[NullableContext(2)]
	[Nullable(0)]
	public class AiStateMachineState
	{
		// Token: 0x0603E9E4 RID: 256484 RVA: 0x0123F05B File Offset: 0x0123D25B
		[NullableContext(1)]
		public AiStateMachineState(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state)
		{
			this.Node = stateMachineNode;
			this.StateData = state;
		}

		// Token: 0x0603E9E5 RID: 256485 RVA: 0x0123F071 File Offset: 0x0123D271
		public bool Init()
		{
			return this.OnInit(this.StateData);
		}

		// Token: 0x0603E9E6 RID: 256486 RVA: 0x0123F07F File Offset: 0x0123D27F
		[NullableContext(1)]
		protected virtual bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			return true;
		}

		// Token: 0x0603E9E7 RID: 256487 RVA: 0x0123F082 File Offset: 0x0123D282
		public virtual void OnEnter(AiStateMachineBase lastState = null, long? contextId = null)
		{
		}

		// Token: 0x0603E9E8 RID: 256488 RVA: 0x0123F084 File Offset: 0x0123D284
		public virtual void OnExit(AiStateMachineBase nextState = null, long? contextId = null)
		{
		}

		// Token: 0x0603E9E9 RID: 256489 RVA: 0x0123F086 File Offset: 0x0123D286
		public virtual void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
		}

		// Token: 0x0603E9EA RID: 256490 RVA: 0x0123F088 File Offset: 0x0123D288
		public virtual void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
		}

		// Token: 0x0603E9EB RID: 256491 RVA: 0x0123F08A File Offset: 0x0123D28A
		public virtual void OnExecuted(long? contextId = null)
		{
		}

		// Token: 0x0603E9EC RID: 256492 RVA: 0x0123F08C File Offset: 0x0123D28C
		public virtual void Tick(float deltaSeconds, long? contextId = null)
		{
			this.OnTick(deltaSeconds, contextId);
		}

		// Token: 0x0603E9ED RID: 256493 RVA: 0x0123F096 File Offset: 0x0123D296
		protected virtual void OnTick(float deltaSeconds, long? contextId = null)
		{
		}

		// Token: 0x0603E9EE RID: 256494 RVA: 0x0123F098 File Offset: 0x0123D298
		public void Clear()
		{
			this.OnClear();
			this.Node = null;
		}

		// Token: 0x0603E9EF RID: 256495 RVA: 0x0123F0A7 File Offset: 0x0123D2A7
		protected virtual void OnClear()
		{
		}

		// Token: 0x0603E9F0 RID: 256496 RVA: 0x0123F0A9 File Offset: 0x0123D2A9
		[NullableContext(1)]
		public virtual void ToString(StringBuilder outBuilder, int depth = 0)
		{
		}

		// Token: 0x040216FF RID: 136959
		public AiStateMachineBase Node;

		// Token: 0x04021700 RID: 136960
		public readonly CombatStateMachineDefine.Fsm.State StateData;
	}
}
