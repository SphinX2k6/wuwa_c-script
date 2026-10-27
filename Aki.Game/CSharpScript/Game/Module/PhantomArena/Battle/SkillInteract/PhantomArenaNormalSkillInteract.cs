using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02005280 RID: 21120
	public class PhantomArenaNormalSkillInteract : PhantomArenaSkillInteractBase
	{
		// Token: 0x0603603E RID: 221246 RVA: 0x00CC86B0 File Offset: 0x00CC68B0
		protected override UniTask<EPhantomArenaSkillInteractExecuteResult> OnExecute([Nullable(1)] PhantomArenaBattleProxy proxy)
		{
			PhantomArenaNormalSkillInteract.<OnExecute>d__0 <OnExecute>d__;
			<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPhantomArenaSkillInteractExecuteResult>.Create();
			<OnExecute>d__.<>4__this = this;
			<OnExecute>d__.<>1__state = -1;
			<OnExecute>d__.<>t__builder.Start<PhantomArenaNormalSkillInteract.<OnExecute>d__0>(ref <OnExecute>d__);
			return <OnExecute>d__.<>t__builder.Task;
		}
	}
}
