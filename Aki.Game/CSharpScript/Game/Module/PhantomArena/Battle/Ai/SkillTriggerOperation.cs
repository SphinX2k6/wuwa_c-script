using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042B6 RID: 17078
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillTriggerOperation : NpcAiOperation
	{
		// Token: 0x170056C8 RID: 22216
		// (get) Token: 0x0602B395 RID: 177045 RVA: 0x00C24F83 File Offset: 0x00C23183
		// (set) Token: 0x0602B396 RID: 177046 RVA: 0x00C24F8B File Offset: 0x00C2318B
		public PhantomBattleSkillTriggerInfo Info { get; private set; }

		// Token: 0x0602B397 RID: 177047 RVA: 0x00C24F94 File Offset: 0x00C23194
		public SkillTriggerOperation(PhantomBattleSkillTriggerInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B398 RID: 177048 RVA: 0x00C24FA4 File Offset: 0x00C231A4
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
