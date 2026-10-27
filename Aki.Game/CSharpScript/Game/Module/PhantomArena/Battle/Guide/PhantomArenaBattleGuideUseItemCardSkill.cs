using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052B5 RID: 21173
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideUseItemCardSkill : PhantomArenaBattleGuideDataBase<IBvbUseItemCardSkill>
	{
		// Token: 0x06036285 RID: 221829 RVA: 0x00CD015A File Offset: 0x00CCE35A
		public PhantomArenaBattleGuideUseItemCardSkill(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x06036286 RID: 221830 RVA: 0x00CD016C File Offset: 0x00CCE36C
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

		// Token: 0x06036287 RID: 221831 RVA: 0x00CD01E2 File Offset: 0x00CCE3E2
		public override void CacheGuideData(params object[] params_)
		{
			if (params_.Length >= 1)
			{
				this.CardId = (int)params_[0];
			}
		}

		// Token: 0x06036288 RID: 221832 RVA: 0x00CD01F8 File Offset: 0x00CCE3F8
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

		// Token: 0x0401CA79 RID: 117369
		protected int CardId = -1;
	}
}
