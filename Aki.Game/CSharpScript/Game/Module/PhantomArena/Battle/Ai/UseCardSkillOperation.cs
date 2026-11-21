using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042B7 RID: 17079
	[NullableContext(1)]
	[Nullable(0)]
	public class UseCardSkillOperation : NpcAiOperation
	{
		// Token: 0x170056C9 RID: 22217
		// (get) Token: 0x0602B399 RID: 177049 RVA: 0x00C24FEF File Offset: 0x00C231EF
		// (set) Token: 0x0602B39A RID: 177050 RVA: 0x00C24FF7 File Offset: 0x00C231F7
		public NpcPhantomBattleCardSkillInfo Info { get; private set; }

		// Token: 0x0602B39B RID: 177051 RVA: 0x00C25000 File Offset: 0x00C23200
		public UseCardSkillOperation(NpcPhantomBattleCardSkillInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B39C RID: 177052 RVA: 0x00C25010 File Offset: 0x00C23210
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			UseCardSkillOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<UseCardSkillOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
