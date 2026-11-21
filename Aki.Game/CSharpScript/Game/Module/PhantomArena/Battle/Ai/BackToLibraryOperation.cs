using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042A6 RID: 17062
	[NullableContext(1)]
	[Nullable(0)]
	public class BackToLibraryOperation : NpcAiOperation
	{
		// Token: 0x170056BB RID: 22203
		// (get) Token: 0x0602B359 RID: 176985 RVA: 0x00C2472B File Offset: 0x00C2292B
		// (set) Token: 0x0602B35A RID: 176986 RVA: 0x00C24733 File Offset: 0x00C22933
		public NpcPhantomBattleBackCardLibrary Info { get; private set; }

		// Token: 0x0602B35B RID: 176987 RVA: 0x00C2473C File Offset: 0x00C2293C
		public BackToLibraryOperation(NpcPhantomBattleBackCardLibrary info)
		{
			this.Info = info;
		}

		// Token: 0x0602B35C RID: 176988 RVA: 0x00C2474C File Offset: 0x00C2294C
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
