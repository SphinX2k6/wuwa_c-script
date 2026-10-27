using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052E4 RID: 21220
	[NullableContext(1)]
	[Nullable(0)]
	public class ReserveCardOperation : NpcAiOperation
	{
		// Token: 0x17008306 RID: 33542
		// (get) Token: 0x06036492 RID: 222354 RVA: 0x00CD7786 File Offset: 0x00CD5986
		// (set) Token: 0x06036493 RID: 222355 RVA: 0x00CD778E File Offset: 0x00CD598E
		public NpcPhantomBattleReserveCardInfo Info { get; private set; }

		// Token: 0x06036494 RID: 222356 RVA: 0x00CD7797 File Offset: 0x00CD5997
		public ReserveCardOperation(NpcPhantomBattleReserveCardInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036495 RID: 222357 RVA: 0x00CD77A8 File Offset: 0x00CD59A8
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
