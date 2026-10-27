using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052B4 RID: 21172
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideUseFieldCardSkill : PhantomArenaBattleGuideDataBase<IBvbUseFieldCardSkill>
	{
		// Token: 0x06036281 RID: 221825 RVA: 0x00CD00BF File Offset: 0x00CCE2BF
		public PhantomArenaBattleGuideUseFieldCardSkill(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x06036282 RID: 221826 RVA: 0x00CD00D0 File Offset: 0x00CCE2D0
		public override bool CheckCanExecute(params object[] params_)
		{
			return true;
		}

		// Token: 0x06036283 RID: 221827 RVA: 0x00CD00D3 File Offset: 0x00CCE2D3
		public override void CacheGuideData(params object[] params_)
		{
			if (params_.Length >= 2)
			{
				this.CardId = (int)params_[0];
				this.SkillId = (int)params_[1];
			}
		}

		// Token: 0x06036284 RID: 221828 RVA: 0x00CD00F8 File Offset: 0x00CCE2F8
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

		// Token: 0x0401CA77 RID: 117367
		protected int CardId = -1;

		// Token: 0x0401CA78 RID: 117368
		protected int SkillId;
	}
}
