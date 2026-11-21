using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042AC RID: 17068
	[NullableContext(1)]
	[Nullable(0)]
	public class FourCostTaskOperation : NpcAiOperation
	{
		// Token: 0x170056C1 RID: 22209
		// (get) Token: 0x0602B371 RID: 177009 RVA: 0x00C24993 File Offset: 0x00C22B93
		// (set) Token: 0x0602B372 RID: 177010 RVA: 0x00C2499B File Offset: 0x00C22B9B
		public NpcPhantomFourCTaskDealCardInfo Info { get; private set; }

		// Token: 0x0602B373 RID: 177011 RVA: 0x00C249A4 File Offset: 0x00C22BA4
		public FourCostTaskOperation(NpcPhantomFourCTaskDealCardInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B374 RID: 177012 RVA: 0x00C249B4 File Offset: 0x00C22BB4
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			FourCostTaskOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<FourCostTaskOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
