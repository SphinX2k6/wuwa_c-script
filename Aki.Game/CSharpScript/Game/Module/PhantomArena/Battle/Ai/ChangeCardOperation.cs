using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052D8 RID: 21208
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeCardOperation : NpcAiOperation
	{
		// Token: 0x170082FD RID: 33533
		// (get) Token: 0x06036466 RID: 222310 RVA: 0x00CD70BB File Offset: 0x00CD52BB
		// (set) Token: 0x06036467 RID: 222311 RVA: 0x00CD70C3 File Offset: 0x00CD52C3
		public NpcPhantomBattleSlotInsteadInfo Info { get; private set; }

		// Token: 0x06036468 RID: 222312 RVA: 0x00CD70CC File Offset: 0x00CD52CC
		public ChangeCardOperation(NpcPhantomBattleSlotInsteadInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036469 RID: 222313 RVA: 0x00CD70DC File Offset: 0x00CD52DC
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			ChangeCardOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<ChangeCardOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
