using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Ai
{
	// Token: 0x020042A9 RID: 17065
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickCardSkillOperation : NpcAiOperation
	{
		// Token: 0x170056BE RID: 22206
		// (get) Token: 0x0602B365 RID: 176997 RVA: 0x00C2484F File Offset: 0x00C22A4F
		// (set) Token: 0x0602B366 RID: 176998 RVA: 0x00C24857 File Offset: 0x00C22A57
		public NpcPhantomBattleCardDurableSkillInfo Info { get; private set; }

		// Token: 0x0602B367 RID: 176999 RVA: 0x00C24860 File Offset: 0x00C22A60
		public ClickCardSkillOperation(NpcPhantomBattleCardDurableSkillInfo info)
		{
			this.Info = info;
		}

		// Token: 0x0602B368 RID: 177000 RVA: 0x00C24870 File Offset: 0x00C22A70
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
