using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052DB RID: 21211
	[NullableContext(1)]
	[Nullable(0)]
	public class EvolveCardOperation : NpcAiOperation
	{
		// Token: 0x17008300 RID: 33536
		// (get) Token: 0x06036472 RID: 222322 RVA: 0x00CD71FF File Offset: 0x00CD53FF
		// (set) Token: 0x06036473 RID: 222323 RVA: 0x00CD7207 File Offset: 0x00CD5407
		public NpcPhantomBattleEvolveInfo Info { get; private set; }

		// Token: 0x06036474 RID: 222324 RVA: 0x00CD7210 File Offset: 0x00CD5410
		public EvolveCardOperation(NpcPhantomBattleEvolveInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036475 RID: 222325 RVA: 0x00CD7220 File Offset: 0x00CD5420
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			EvolveCardOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<EvolveCardOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
