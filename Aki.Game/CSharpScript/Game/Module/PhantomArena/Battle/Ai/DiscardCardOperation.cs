using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042AA RID: 17066
	[NullableContext(1)]
	[Nullable(0)]
	public class DiscardCardOperation : NpcAiOperation
	{
		// Token: 0x170056BF RID: 22207
		// (get) Token: 0x0602B369 RID: 177001 RVA: 0x00C248BB File Offset: 0x00C22ABB
		// (set) Token: 0x0602B36A RID: 177002 RVA: 0x00C248C3 File Offset: 0x00C22AC3
		public NpcPhantomBattleDiscardInfo Info { get; private set; }

		// Token: 0x0602B36B RID: 177003 RVA: 0x00C248CC File Offset: 0x00C22ACC
		public DiscardCardOperation(NpcPhantomBattleDiscardInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B36C RID: 177004 RVA: 0x00C248DC File Offset: 0x00C22ADC
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
