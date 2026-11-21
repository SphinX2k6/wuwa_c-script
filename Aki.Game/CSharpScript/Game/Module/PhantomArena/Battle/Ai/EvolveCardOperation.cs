using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042AB RID: 17067
	[NullableContext(1)]
	[Nullable(0)]
	public class EvolveCardOperation : NpcAiOperation
	{
		// Token: 0x170056C0 RID: 22208
		// (get) Token: 0x0602B36D RID: 177005 RVA: 0x00C24927 File Offset: 0x00C22B27
		// (set) Token: 0x0602B36E RID: 177006 RVA: 0x00C2492F File Offset: 0x00C22B2F
		public NpcPhantomBattleEvolveInfo Info { get; private set; }

		// Token: 0x0602B36F RID: 177007 RVA: 0x00C24938 File Offset: 0x00C22B38
		public EvolveCardOperation(NpcPhantomBattleEvolveInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B370 RID: 177008 RVA: 0x00C24948 File Offset: 0x00C22B48
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
