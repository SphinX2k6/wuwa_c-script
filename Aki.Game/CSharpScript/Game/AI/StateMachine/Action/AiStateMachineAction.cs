using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064CD RID: 25805
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineAction
	{
		// Token: 0x0603EADC RID: 256732 RVA: 0x01243248 File Offset: 0x01241448
		public AiStateMachineAction(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action)
		{
			this.Node = stateMachineNode;
			this.ActionData = action;
		}

		// Token: 0x0603EADD RID: 256733 RVA: 0x0124325E File Offset: 0x0124145E
		public virtual void DoAction(long? contextId = null)
		{
		}

		// Token: 0x0603EADE RID: 256734 RVA: 0x01243260 File Offset: 0x01241460
		public bool Init()
		{
			return this.OnInit(this.ActionData);
		}

		// Token: 0x0603EADF RID: 256735 RVA: 0x0124326E File Offset: 0x0124146E
		protected virtual bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			return true;
		}

		// Token: 0x0603EAE0 RID: 256736 RVA: 0x01243271 File Offset: 0x01241471
		public void Clear()
		{
			this.OnClear();
			this.Node = null;
		}

		// Token: 0x0603EAE1 RID: 256737 RVA: 0x01243280 File Offset: 0x01241480
		protected virtual void OnClear()
		{
		}

		// Token: 0x0603EAE2 RID: 256738 RVA: 0x01243282 File Offset: 0x01241482
		public virtual void ToString(StringBuilder outBuilder, int depth = 0)
		{
		}

		// Token: 0x04021760 RID: 137056
		[Nullable(2)]
		public AiStateMachineBase Node;

		// Token: 0x04021761 RID: 137057
		[Nullable(2)]
		private readonly CombatStateMachineDefine.Fsm.Action ActionData;
	}
}
