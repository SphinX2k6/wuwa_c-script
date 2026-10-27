using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052DC RID: 21212
	[NullableContext(1)]
	[Nullable(0)]
	public class FourCostTaskOperation : NpcAiOperation
	{
		// Token: 0x17008301 RID: 33537
		// (get) Token: 0x06036476 RID: 222326 RVA: 0x00CD726B File Offset: 0x00CD546B
		// (set) Token: 0x06036477 RID: 222327 RVA: 0x00CD7273 File Offset: 0x00CD5473
		public NpcPhantomFourCTaskDealCardInfo Info { get; private set; }

		// Token: 0x06036478 RID: 222328 RVA: 0x00CD727C File Offset: 0x00CD547C
		public FourCostTaskOperation(NpcPhantomFourCTaskDealCardInfo info)
		{
			this.Info = info;
		}

		// Token: 0x06036479 RID: 222329 RVA: 0x00CD728C File Offset: 0x00CD548C
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
