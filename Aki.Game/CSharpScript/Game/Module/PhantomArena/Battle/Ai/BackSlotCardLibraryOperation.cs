using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052D5 RID: 21205
	[NullableContext(1)]
	[Nullable(0)]
	public class BackSlotCardLibraryOperation : NpcAiOperation
	{
		// Token: 0x170082FA RID: 33530
		// (get) Token: 0x0603645A RID: 222298 RVA: 0x00CD6F95 File Offset: 0x00CD5195
		// (set) Token: 0x0603645B RID: 222299 RVA: 0x00CD6F9D File Offset: 0x00CD519D
		public NpcPhantomBattleBackSlotCardLibrary Info { get; private set; }

		// Token: 0x0603645C RID: 222300 RVA: 0x00CD6FA6 File Offset: 0x00CD51A6
		public BackSlotCardLibraryOperation(NpcPhantomBattleBackSlotCardLibrary info)
		{
			this.Info = info;
		}

		// Token: 0x0603645D RID: 222301 RVA: 0x00CD6FB8 File Offset: 0x00CD51B8
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			BackSlotCardLibraryOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<BackSlotCardLibraryOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
