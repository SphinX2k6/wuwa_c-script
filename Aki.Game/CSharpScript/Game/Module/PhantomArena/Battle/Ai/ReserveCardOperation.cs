using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042B4 RID: 17076
	[NullableContext(1)]
	[Nullable(0)]
	public class ReserveCardOperation : NpcAiOperation
	{
		// Token: 0x170056C6 RID: 22214
		// (get) Token: 0x0602B38D RID: 177037 RVA: 0x00C24EAA File Offset: 0x00C230AA
		// (set) Token: 0x0602B38E RID: 177038 RVA: 0x00C24EB2 File Offset: 0x00C230B2
		public NpcPhantomBattleReserveCardInfo Info { get; private set; }

		// Token: 0x0602B38F RID: 177039 RVA: 0x00C24EBB File Offset: 0x00C230BB
		public ReserveCardOperation(NpcPhantomBattleReserveCardInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B390 RID: 177040 RVA: 0x00C24ECC File Offset: 0x00C230CC
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			ReserveCardOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<ReserveCardOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
