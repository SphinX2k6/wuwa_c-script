using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042AE RID: 17070
	[NullableContext(1)]
	[Nullable(0)]
	public class LeaveSlotOperation : NpcAiOperation
	{
		// Token: 0x170056C3 RID: 22211
		// (get) Token: 0x0602B379 RID: 177017 RVA: 0x00C24A8D File Offset: 0x00C22C8D
		// (set) Token: 0x0602B37A RID: 177018 RVA: 0x00C24A95 File Offset: 0x00C22C95
		public NpcPhantomLeaveSlot Info { get; private set; }

		// Token: 0x0602B37B RID: 177019 RVA: 0x00C24A9E File Offset: 0x00C22C9E
		public LeaveSlotOperation(NpcPhantomLeaveSlot info)
		{
			this.Info = info;
		}

		// Token: 0x0602B37C RID: 177020 RVA: 0x00C24AB0 File Offset: 0x00C22CB0
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
