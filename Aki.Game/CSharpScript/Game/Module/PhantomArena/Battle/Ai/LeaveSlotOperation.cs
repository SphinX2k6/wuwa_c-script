using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052DE RID: 21214
	[NullableContext(1)]
	[Nullable(0)]
	public class LeaveSlotOperation : NpcAiOperation
	{
		// Token: 0x17008303 RID: 33539
		// (get) Token: 0x0603647E RID: 222334 RVA: 0x00CD7365 File Offset: 0x00CD5565
		// (set) Token: 0x0603647F RID: 222335 RVA: 0x00CD736D File Offset: 0x00CD556D
		public NpcPhantomLeaveSlot Info { get; private set; }

		// Token: 0x06036480 RID: 222336 RVA: 0x00CD7376 File Offset: 0x00CD5576
		public LeaveSlotOperation(NpcPhantomLeaveSlot info)
		{
			this.Info = info;
		}

		// Token: 0x06036481 RID: 222337 RVA: 0x00CD7388 File Offset: 0x00CD5588
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			LeaveSlotOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<LeaveSlotOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
