using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02005281 RID: 21121
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaPassiveSkillTriggerLogic : ISkillInteractMainInterface
	{
		// Token: 0x06036040 RID: 221248 RVA: 0x00CC86FC File Offset: 0x00CC68FC
		public PhantomArenaPassiveSkillTriggerLogic(PhantomBattleSelectTargetEffectNotify notify, PhantomArenaBattleProxy viewProxy)
		{
			this.ViewProxy = viewProxy;
			this.Data = new SkillTriggerInfo
			{
				InteractType = (EPhantomArenaBuffEffectType)notify.EffectType,
				SelectFightIdList = new List<int>(notify.FighterUId),
				SelectNum = notify.Num,
				IsRole = false,
				IsPassive = true,
				IsFight = false,
				IsClickInteract = false,
				DataId = new int?(notify.OwnerUid)
			};
		}

		// Token: 0x06036041 RID: 221249 RVA: 0x00CC8778 File Offset: 0x00CC6978
		public UniTask Execute()
		{
			PhantomArenaPassiveSkillTriggerLogic.<Execute>d__3 <Execute>d__;
			<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Execute>d__.<>4__this = this;
			<Execute>d__.<>1__state = -1;
			<Execute>d__.<>t__builder.Start<PhantomArenaPassiveSkillTriggerLogic.<Execute>d__3>(ref <Execute>d__);
			return <Execute>d__.<>t__builder.Task;
		}

		// Token: 0x06036042 RID: 221250 RVA: 0x00CC87BB File Offset: 0x00CC69BB
		public ISkillTriggerInfo GetData()
		{
			return this.Data;
		}

		// Token: 0x06036043 RID: 221251 RVA: 0x00CC87C4 File Offset: 0x00CC69C4
		public UniTask StartSkillInteract()
		{
			return default(UniTask);
		}

		// Token: 0x06036044 RID: 221252 RVA: 0x00CC87DA File Offset: 0x00CC69DA
		public void CancelSkillInteract()
		{
		}

		// Token: 0x06036045 RID: 221253 RVA: 0x00CC87DC File Offset: 0x00CC69DC
		public void FinishSkillInteract()
		{
		}

		// Token: 0x0401C99B RID: 117147
		protected SkillTriggerInfo Data;

		// Token: 0x0401C99C RID: 117148
		protected PhantomArenaBattleProxy ViewProxy;
	}
}
