using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x02004284 RID: 17028
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideUseFieldCardSkill : PhantomArenaBattleGuideDataBase<IBvbUseFieldCardSkill>
	{
		// Token: 0x0602B17C RID: 176508 RVA: 0x00C1D7E7 File Offset: 0x00C1B9E7
		public PhantomArenaBattleGuideUseFieldCardSkill(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0602B17D RID: 176509 RVA: 0x00C1D7F8 File Offset: 0x00C1B9F8
		public override bool CheckCanExecute(params object[] params_)
		{
			return true;
		}

		// Token: 0x0602B17E RID: 176510 RVA: 0x00C1D7FB File Offset: 0x00C1B9FB
		public override void CacheGuideData(params object[] params_)
		{
			if (params_.Length >= 2)
			{
				this.CardId = (int)params_[0];
				this.SkillId = (int)params_[1];
			}
		}

		// Token: 0x0602B17F RID: 176511 RVA: 0x00C1D820 File Offset: 0x00C1BA20
		public override bool CheckCanFinishGuide(params object[] params_)
		{
			if (params_.Length < 2)
			{
				return false;
			}
			bool flag = (EPhantomArenaSkillInteractExecuteResult)params_[0] != EPhantomArenaSkillInteractExecuteResult.Success;
			IPhantomArenaGuideCardSkillData phantomArenaGuideCardSkillData = (IPhantomArenaGuideCardSkillData)params_[1];
			return !flag && (phantomArenaGuideCardSkillData.BuffType == null || !PhantomArenaSkillInteractFactory.HasSkillInteract((int)phantomArenaGuideCardSkillData.BuffType.Value)) && phantomArenaGuideCardSkillData.CardId == this.CardId;
		}

		// Token: 0x040174AC RID: 95404
		protected int CardId = -1;

		// Token: 0x040174AD RID: 95405
		protected int SkillId;
	}
}
