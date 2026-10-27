using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x02007317 RID: 29463
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineTask
	{
		// Token: 0x17009F81 RID: 40833
		// (get) Token: 0x06048512 RID: 296210 RVA: 0x0129914F File Offset: 0x0129734F
		// (set) Token: 0x06048513 RID: 296211 RVA: 0x01299157 File Offset: 0x01297357
		public virtual bool IsAsyncTask { get; set; }

		// Token: 0x06048514 RID: 296212 RVA: 0x01299160 File Offset: 0x01297360
		public AiStateMachineTask(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state)
		{
			this.Node = stateMachineNode;
			this.StateData = state;
			this.CanBeInterrupt = state.CanBeInterrupt;
		}

		// Token: 0x17009F82 RID: 40834
		// (get) Token: 0x06048515 RID: 296213 RVA: 0x01299182 File Offset: 0x01297382
		public CombatStateMachineDefine.Fsm.ETaskType Type
		{
			get
			{
				return (CombatStateMachineDefine.Fsm.ETaskType)this.StateData.Type;
			}
		}

		// Token: 0x06048516 RID: 296214 RVA: 0x0129918F File Offset: 0x0129738F
		public bool Init()
		{
			return this.OnInit(this.StateData);
		}

		// Token: 0x06048517 RID: 296215 RVA: 0x0129919D File Offset: 0x0129739D
		protected virtual bool OnInit(CombatStateMachineDefine.Fsm.Task task)
		{
			return true;
		}

		// Token: 0x06048518 RID: 296216 RVA: 0x012991A0 File Offset: 0x012973A0
		public virtual void OnEnter(long? contextId = null)
		{
		}

		// Token: 0x06048519 RID: 296217 RVA: 0x012991A2 File Offset: 0x012973A2
		public virtual void OnExit(long? contextId = null)
		{
		}

		// Token: 0x0604851A RID: 296218 RVA: 0x012991A4 File Offset: 0x012973A4
		public virtual void OnActivate(long? contextId = null)
		{
		}

		// Token: 0x0604851B RID: 296219 RVA: 0x012991A6 File Offset: 0x012973A6
		public virtual void OnDeactivate(long? contextId = null)
		{
		}

		// Token: 0x0604851C RID: 296220 RVA: 0x012991A8 File Offset: 0x012973A8
		public virtual void OnExecuted(long? contextId = null)
		{
		}

		// Token: 0x0604851D RID: 296221 RVA: 0x012991AA File Offset: 0x012973AA
		public virtual void Tick(float deltaSeconds, long? contextId = null)
		{
			this.OnTick(deltaSeconds, contextId);
		}

		// Token: 0x0604851E RID: 296222 RVA: 0x012991B4 File Offset: 0x012973B4
		protected virtual void OnTick(float deltaSeconds, long? contextId = null)
		{
		}

		// Token: 0x0604851F RID: 296223 RVA: 0x012991B6 File Offset: 0x012973B6
		public void Clear()
		{
			this.OnClear();
			this.Node = null;
			this.StateData = null;
		}

		// Token: 0x06048520 RID: 296224 RVA: 0x012991CC File Offset: 0x012973CC
		protected virtual void OnClear()
		{
		}

		// Token: 0x06048521 RID: 296225 RVA: 0x012991CE File Offset: 0x012973CE
		public virtual void ToString(StringBuilder outBuilder, int depth = 0)
		{
		}

		// Token: 0x040263BB RID: 156603
		[Nullable(2)]
		public AiStateMachineBase Node;

		// Token: 0x040263BC RID: 156604
		[Nullable(2)]
		private CombatStateMachineDefine.Fsm.Task StateData;

		// Token: 0x040263BD RID: 156605
		public bool CanBeInterrupt;
	}
}
