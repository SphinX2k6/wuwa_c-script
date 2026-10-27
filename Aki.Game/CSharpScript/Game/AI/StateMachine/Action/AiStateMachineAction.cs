using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x0200734A RID: 29514
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineAction
	{
		// Token: 0x0604868F RID: 296591 RVA: 0x012A07C0 File Offset: 0x0129E9C0
		public AiStateMachineAction(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action)
		{
			this.Node = stateMachineNode;
			this.ActionData = action;
		}

		// Token: 0x06048690 RID: 296592 RVA: 0x012A07D6 File Offset: 0x0129E9D6
		public virtual void DoAction(long? contextId = null)
		{
		}

		// Token: 0x06048691 RID: 296593 RVA: 0x012A07D8 File Offset: 0x0129E9D8
		public bool Init()
		{
			return this.OnInit(this.ActionData);
		}

		// Token: 0x06048692 RID: 296594 RVA: 0x012A07E6 File Offset: 0x0129E9E6
		protected virtual bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			return true;
		}

		// Token: 0x06048693 RID: 296595 RVA: 0x012A07E9 File Offset: 0x0129E9E9
		public void Clear()
		{
			this.OnClear();
			this.Node = null;
		}

		// Token: 0x06048694 RID: 296596 RVA: 0x012A07F8 File Offset: 0x0129E9F8
		protected virtual void OnClear()
		{
		}

		// Token: 0x06048695 RID: 296597 RVA: 0x012A07FA File Offset: 0x0129E9FA
		public virtual void ToString(StringBuilder outBuilder, int depth = 0)
		{
		}

		// Token: 0x04026473 RID: 156787
		[Nullable(2)]
		public AiStateMachineBase Node;

		// Token: 0x04026474 RID: 156788
		[Nullable(2)]
		private readonly CombatStateMachineDefine.Fsm.Action ActionData;
	}
}
