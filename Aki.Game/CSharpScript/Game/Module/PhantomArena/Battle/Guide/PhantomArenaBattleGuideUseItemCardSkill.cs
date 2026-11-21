using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x02004285 RID: 17029
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideUseItemCardSkill : PhantomArenaBattleGuideDataBase<IBvbUseItemCardSkill>
	{
		// Token: 0x0602B180 RID: 176512 RVA: 0x00C1D882 File Offset: 0x00C1BA82
		public PhantomArenaBattleGuideUseItemCardSkill(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0602B181 RID: 176513 RVA: 0x00C1D894 File Offset: 0x00C1BA94
		public override bool CheckCanExecute(params object[] params_)
		{
			if (params_.Length < 1)
			{
				return false;
			}
			int num = (int)params_[0];
			if (num == -1)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "PhantomArenaBattleGuideUseItemCardSkill invalid value";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("battleIndex", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return this.Data.BoardPosIndexList == null || this.Data.BoardPosIndexList.Contains(num + 1);
		}

		// Token: 0x0602B182 RID: 176514 RVA: 0x00C1D90A File Offset: 0x00C1BB0A
		public override void CacheGuideData(params object[] params_)
		{
			if (params_.Length >= 1)
			{
				this.CardId = (int)params_[0];
			}
		}

		// Token: 0x0602B183 RID: 176515 RVA: 0x00C1D920 File Offset: 0x00C1BB20
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

		// Token: 0x040174AE RID: 95406
		protected int CardId = -1;
	}
}
