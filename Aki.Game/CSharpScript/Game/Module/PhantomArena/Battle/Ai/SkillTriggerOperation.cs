using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020052E6 RID: 21222
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillTriggerOperation : NpcAiOperation
	{
		// Token: 0x17008308 RID: 33544
		// (get) Token: 0x0603649A RID: 222362 RVA: 0x00CD785F File Offset: 0x00CD5A5F
		// (set) Token: 0x0603649B RID: 222363 RVA: 0x00CD7867 File Offset: 0x00CD5A67
		public PhantomBattleSkillTriggerInfo Info { get; private set; }

		// Token: 0x0603649C RID: 222364 RVA: 0x00CD7870 File Offset: 0x00CD5A70
		public SkillTriggerOperation(PhantomBattleSkillTriggerInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0603649D RID: 222365 RVA: 0x00CD7880 File Offset: 0x00CD5A80
		public override UniTask ExecuteAiOperation(PhantomArenaBattleProxy proxy)
		{
			SkillTriggerOperation.<ExecuteAiOperation>d__5 <ExecuteAiOperation>d__;
			<ExecuteAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteAiOperation>d__.<>4__this = this;
			<ExecuteAiOperation>d__.proxy = proxy;
			<ExecuteAiOperation>d__.<>1__state = -1;
			<ExecuteAiOperation>d__.<>t__builder.Start<SkillTriggerOperation.<ExecuteAiOperation>d__5>(ref <ExecuteAiOperation>d__);
			return <ExecuteAiOperation>d__.<>t__builder.Task;
		}
	}
}
