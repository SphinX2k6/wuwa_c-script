using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02005283 RID: 21123
	public abstract class PhantomArenaSkillInteractBase
	{
		// Token: 0x06036055 RID: 221269 RVA: 0x00CC8F00 File Offset: 0x00CC7100
		[NullableContext(1)]
		[return: Nullable(0)]
		public UniTask<EPhantomArenaSkillInteractExecuteResult> Execute(PhantomArenaBattleProxy proxy, ISkillInteractMainInterface info)
		{
			PhantomArenaSkillInteractBase.<Execute>d__3 <Execute>d__;
			<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPhantomArenaSkillInteractExecuteResult>.Create();
			<Execute>d__.<>4__this = this;
			<Execute>d__.proxy = proxy;
			<Execute>d__.info = info;
			<Execute>d__.<>1__state = -1;
			<Execute>d__.<>t__builder.Start<PhantomArenaSkillInteractBase.<Execute>d__3>(ref <Execute>d__);
			return <Execute>d__.<>t__builder.Task;
		}

		// Token: 0x06036056 RID: 221270
		protected abstract UniTask<EPhantomArenaSkillInteractExecuteResult> OnExecute([Nullable(1)] PhantomArenaBattleProxy proxy);

		// Token: 0x06036057 RID: 221271 RVA: 0x00CC8F54 File Offset: 0x00CC7154
		protected UniTask<bool> RequestSelectResultInfo([Nullable(1)] List<int> fightIdList)
		{
			PhantomArenaSkillInteractBase.<RequestSelectResultInfo>d__5 <RequestSelectResultInfo>d__;
			<RequestSelectResultInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestSelectResultInfo>d__.<>4__this = this;
			<RequestSelectResultInfo>d__.fightIdList = fightIdList;
			<RequestSelectResultInfo>d__.<>1__state = -1;
			<RequestSelectResultInfo>d__.<>t__builder.Start<PhantomArenaSkillInteractBase.<RequestSelectResultInfo>d__5>(ref <RequestSelectResultInfo>d__);
			return <RequestSelectResultInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06036058 RID: 221272 RVA: 0x00CC8FA0 File Offset: 0x00CC71A0
		protected UniTask<bool> PassiveSkillRequest([Nullable(1)] List<int> fightIdList)
		{
			PhantomArenaSkillInteractBase.<PassiveSkillRequest>d__6 <PassiveSkillRequest>d__;
			<PassiveSkillRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PassiveSkillRequest>d__.fightIdList = fightIdList;
			<PassiveSkillRequest>d__.<>1__state = -1;
			<PassiveSkillRequest>d__.<>t__builder.Start<PhantomArenaSkillInteractBase.<PassiveSkillRequest>d__6>(ref <PassiveSkillRequest>d__);
			return <PassiveSkillRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0401C9A0 RID: 117152
		[Nullable(1)]
		protected PhantomArenaBattleProxy BattleProxy;

		// Token: 0x0401C9A1 RID: 117153
		[Nullable(1)]
		protected ISkillInteractMainInterface Info;

		// Token: 0x0401C9A2 RID: 117154
		[Nullable(1)]
		protected ISkillTriggerInfo Data;
	}
}
