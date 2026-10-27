using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x0200527F RID: 21119
	public class PhantomArenaChooseCardSkillInteract : PhantomArenaSkillInteractBase
	{
		// Token: 0x0603603C RID: 221244 RVA: 0x00CC8664 File Offset: 0x00CC6864
		protected override UniTask<EPhantomArenaSkillInteractExecuteResult> OnExecute([Nullable(1)] PhantomArenaBattleProxy proxy)
		{
			PhantomArenaChooseCardSkillInteract.<OnExecute>d__0 <OnExecute>d__;
			<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPhantomArenaSkillInteractExecuteResult>.Create();
			<OnExecute>d__.<>4__this = this;
			<OnExecute>d__.<>1__state = -1;
			<OnExecute>d__.<>t__builder.Start<PhantomArenaChooseCardSkillInteract.<OnExecute>d__0>(ref <OnExecute>d__);
			return <OnExecute>d__.<>t__builder.Task;
		}
	}
}
