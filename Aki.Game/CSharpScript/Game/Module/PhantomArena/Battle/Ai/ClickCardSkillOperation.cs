using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052D9 RID: 21209
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickCardSkillOperation : NpcAiOperation
	{
		// Token: 0x170082FE RID: 33534
		// (get) Token: 0x0603646A RID: 222314 RVA: 0x00CD7127 File Offset: 0x00CD5327
		// (set) Token: 0x0603646B RID: 222315 RVA: 0x00CD712F File Offset: 0x00CD532F
		public NpcPhantomBattleCardDurableSkillInfo Info { get; private set; }

		// Token: 0x0603646C RID: 222316 RVA: 0x00CD7138 File Offset: 0x00CD5338
		public ClickCardSkillOperation(NpcPhantomBattleCardDurableSkillInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0603646D RID: 222317 RVA: 0x00CD7148 File Offset: 0x00CD5348
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			ClickCardSkillOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<ClickCardSkillOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
