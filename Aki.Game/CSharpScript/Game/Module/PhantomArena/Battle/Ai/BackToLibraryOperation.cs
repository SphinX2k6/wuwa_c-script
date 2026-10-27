using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052D6 RID: 21206
	[NullableContext(1)]
	[Nullable(0)]
	public class BackToLibraryOperation : NpcAiOperation
	{
		// Token: 0x170082FB RID: 33531
		// (get) Token: 0x0603645E RID: 222302 RVA: 0x00CD7003 File Offset: 0x00CD5203
		// (set) Token: 0x0603645F RID: 222303 RVA: 0x00CD700B File Offset: 0x00CD520B
		public NpcPhantomBattleBackCardLibrary Info { get; private set; }

		// Token: 0x06036460 RID: 222304 RVA: 0x00CD7014 File Offset: 0x00CD5214
		public BackToLibraryOperation(NpcPhantomBattleBackCardLibrary info)
		{
			this.Info = info;
		}

		// Token: 0x06036461 RID: 222305 RVA: 0x00CD7024 File Offset: 0x00CD5224
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			BackToLibraryOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<BackToLibraryOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
