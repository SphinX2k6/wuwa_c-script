using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042A8 RID: 17064
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeCardOperation : NpcAiOperation
	{
		// Token: 0x170056BD RID: 22205
		// (get) Token: 0x0602B361 RID: 176993 RVA: 0x00C247E3 File Offset: 0x00C229E3
		// (set) Token: 0x0602B362 RID: 176994 RVA: 0x00C247EB File Offset: 0x00C229EB
		public NpcPhantomBattleSlotInsteadInfo Info { get; private set; }

		// Token: 0x0602B363 RID: 176995 RVA: 0x00C247F4 File Offset: 0x00C229F4
		public ChangeCardOperation(NpcPhantomBattleSlotInsteadInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B364 RID: 176996 RVA: 0x00C24804 File Offset: 0x00C22A04
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
