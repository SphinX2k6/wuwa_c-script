using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052E7 RID: 21223
	[NullableContext(1)]
	[Nullable(0)]
	public class UseCardSkillOperation : NpcAiOperation
	{
		// Token: 0x17008309 RID: 33545
		// (get) Token: 0x0603649E RID: 222366 RVA: 0x00CD78CB File Offset: 0x00CD5ACB
		// (set) Token: 0x0603649F RID: 222367 RVA: 0x00CD78D3 File Offset: 0x00CD5AD3
		public NpcPhantomBattleCardSkillInfo Info { get; private set; }

		// Token: 0x060364A0 RID: 222368 RVA: 0x00CD78DC File Offset: 0x00CD5ADC
		public UseCardSkillOperation(NpcPhantomBattleCardSkillInfo info)
		{
			this.Info = info;
		}

		// Token: 0x060364A1 RID: 222369 RVA: 0x00CD78EC File Offset: 0x00CD5AEC
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
