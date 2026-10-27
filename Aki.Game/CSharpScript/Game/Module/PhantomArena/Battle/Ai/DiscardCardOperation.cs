using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052DA RID: 21210
	[NullableContext(1)]
	[Nullable(0)]
	public class DiscardCardOperation : NpcAiOperation
	{
		// Token: 0x170082FF RID: 33535
		// (get) Token: 0x0603646E RID: 222318 RVA: 0x00CD7193 File Offset: 0x00CD5393
		// (set) Token: 0x0603646F RID: 222319 RVA: 0x00CD719B File Offset: 0x00CD539B
		public NpcPhantomBattleDiscardInfo Info { get; private set; }

		// Token: 0x06036470 RID: 222320 RVA: 0x00CD71A4 File Offset: 0x00CD53A4
		public DiscardCardOperation(NpcPhantomBattleDiscardInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036471 RID: 222321 RVA: 0x00CD71B4 File Offset: 0x00CD53B4
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			DiscardCardOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<DiscardCardOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
