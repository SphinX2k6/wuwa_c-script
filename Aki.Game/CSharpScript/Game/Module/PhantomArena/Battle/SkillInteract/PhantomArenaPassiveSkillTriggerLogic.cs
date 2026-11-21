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
	// Token: 0x02004251 RID: 16977
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaPassiveSkillTriggerLogic : ISkillInteractMainInterface
	{
		// Token: 0x0602AF3B RID: 175931 RVA: 0x00C15E00 File Offset: 0x00C14000
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

		// Token: 0x0602AF3C RID: 175932 RVA: 0x00C15E7C File Offset: 0x00C1407C
		public UniTask Execute()
		{
			PhantomArenaPassiveSkillTriggerLogic.<Execute>d__3 <Execute>d__;
			<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Execute>d__.<>4__this = this;
			<Execute>d__.<>1__state = -1;
			<Execute>d__.<>t__builder.Start<PhantomArenaPassiveSkillTriggerLogic.<Execute>d__3>(ref <Execute>d__);
			return <Execute>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF3D RID: 175933 RVA: 0x00C15EBF File Offset: 0x00C140BF
		public ISkillTriggerInfo GetData()
		{
			return this.Data;
		}

		// Token: 0x0602AF3E RID: 175934 RVA: 0x00C15EC8 File Offset: 0x00C140C8
		public UniTask StartSkillInteract()
		{
			return default(UniTask);
		}

		// Token: 0x0602AF3F RID: 175935 RVA: 0x00C15EDE File Offset: 0x00C140DE
		public void CancelSkillInteract()
		{
		}

		// Token: 0x0602AF40 RID: 175936 RVA: 0x00C15EE0 File Offset: 0x00C140E0
		public void FinishSkillInteract()
		{
		}

		// Token: 0x040173D0 RID: 95184
		protected SkillTriggerInfo Data;

		// Token: 0x040173D1 RID: 95185
		protected PhantomArenaBattleProxy ViewProxy;
	}
}
