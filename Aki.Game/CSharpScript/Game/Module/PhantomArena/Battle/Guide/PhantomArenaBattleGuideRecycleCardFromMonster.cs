using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052B1 RID: 21169
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideRecycleCardFromMonster : PhantomArenaBattleGuideDataBase<IBvbRecycleBoardCard>
	{
		// Token: 0x0603627B RID: 221819 RVA: 0x00CCFED1 File Offset: 0x00CCE0D1
		public PhantomArenaBattleGuideRecycleCardFromMonster(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0603627C RID: 221820 RVA: 0x00CCFEDC File Offset: 0x00CCE0DC
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
				string message = "PhantomArenaBattleGuideRecycleCardFromMonster invalid value";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("battleIndex", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return this.Data.BoardPosIndexList == null || this.Data.BoardPosIndexList.Contains(num + 1);
		}
	}
}
