using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x0200649A RID: 25754
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTask
	{
		// Token: 0x1700771F RID: 30495
		// (get) Token: 0x0603E95F RID: 256351 RVA: 0x0123BBCF File Offset: 0x01239DCF
		// (set) Token: 0x0603E960 RID: 256352 RVA: 0x0123BBD7 File Offset: 0x01239DD7
		public virtual bool IsAsyncTask { get; set; }

		// Token: 0x0603E961 RID: 256353 RVA: 0x0123BBE0 File Offset: 0x01239DE0
		public AiStateMachineTask(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state)
		{
			this.Node = stateMachineNode;
			this.StateData = state;
			this.CanBeInterrupt = state.CanBeInterrupt;
		}

		// Token: 0x17007720 RID: 30496
		// (get) Token: 0x0603E962 RID: 256354 RVA: 0x0123BC02 File Offset: 0x01239E02
		public CombatStateMachineDefine.Fsm.ETaskType Type
		{
			get
			{
				return (CombatStateMachineDefine.Fsm.ETaskType)this.StateData.Type;
			}
		}

		// Token: 0x0603E963 RID: 256355 RVA: 0x0123BC0F File Offset: 0x01239E0F
		public bool Init()
		{
			return this.OnInit(this.StateData);
		}

		// Token: 0x0603E964 RID: 256356 RVA: 0x0123BC1D File Offset: 0x01239E1D
		protected virtual bool OnInit(CombatStateMachineDefine.Fsm.Task task)
		{
			return true;
		}

		// Token: 0x0603E965 RID: 256357 RVA: 0x0123BC20 File Offset: 0x01239E20
		public virtual void OnEnter(long? contextId = null)
		{
		}

		// Token: 0x0603E966 RID: 256358 RVA: 0x0123BC22 File Offset: 0x01239E22
		public virtual void OnExit(long? contextId = null)
		{
		}

		// Token: 0x0603E967 RID: 256359 RVA: 0x0123BC24 File Offset: 0x01239E24
		public virtual void OnActivate(long? contextId = null)
		{
		}

		// Token: 0x0603E968 RID: 256360 RVA: 0x0123BC26 File Offset: 0x01239E26
		public virtual void OnDeactivate(long? contextId = null)
		{
		}

		// Token: 0x0603E969 RID: 256361 RVA: 0x0123BC28 File Offset: 0x01239E28
		public virtual void OnExecuted(long? contextId = null)
		{
		}

		// Token: 0x0603E96A RID: 256362 RVA: 0x0123BC2A File Offset: 0x01239E2A
		public virtual void Tick(float deltaSeconds, long? contextId = null)
		{
			this.OnTick(deltaSeconds, contextId);
		}

		// Token: 0x0603E96B RID: 256363 RVA: 0x0123BC34 File Offset: 0x01239E34
		protected virtual void OnTick(float deltaSeconds, long? contextId = null)
		{
		}

		// Token: 0x0603E96C RID: 256364 RVA: 0x0123BC36 File Offset: 0x01239E36
		public void Clear()
		{
			this.OnClear();
			this.Node = null;
			this.StateData = null;
		}

		// Token: 0x0603E96D RID: 256365 RVA: 0x0123BC4C File Offset: 0x01239E4C
		protected virtual void OnClear()
		{
		}

		// Token: 0x0603E96E RID: 256366 RVA: 0x0123BC4E File Offset: 0x01239E4E
		public virtual void ToString(StringBuilder outBuilder, int depth = 0)
		{
		}

		// Token: 0x040216A8 RID: 136872
		[Nullable(2)]
		public AiStateMachineBase Node;

		// Token: 0x040216A9 RID: 136873
		[Nullable(2)]
		private CombatStateMachineDefine.Fsm.Task StateData;

		// Token: 0x040216AA RID: 136874
		public bool CanBeInterrupt;
	}
}
