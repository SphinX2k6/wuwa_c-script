using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042A5 RID: 17061
	[NullableContext(1)]
	[Nullable(0)]
	public class BackSlotCardLibraryOperation : NpcAiOperation
	{
		// Token: 0x170056BA RID: 22202
		// (get) Token: 0x0602B355 RID: 176981 RVA: 0x00C246BD File Offset: 0x00C228BD
		// (set) Token: 0x0602B356 RID: 176982 RVA: 0x00C246C5 File Offset: 0x00C228C5
		public NpcPhantomBattleBackSlotCardLibrary Info { get; private set; }

		// Token: 0x0602B357 RID: 176983 RVA: 0x00C246CE File Offset: 0x00C228CE
		public BackSlotCardLibraryOperation(NpcPhantomBattleBackSlotCardLibrary info)
		{
			this.Info = info;
		}

		// Token: 0x0602B358 RID: 176984 RVA: 0x00C246E0 File Offset: 0x00C228E0
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
