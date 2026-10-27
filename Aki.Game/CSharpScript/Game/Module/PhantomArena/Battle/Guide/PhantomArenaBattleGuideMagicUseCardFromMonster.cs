using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052AE RID: 21166
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideMagicUseCardFromMonster : PhantomArenaBattleGuideDataBase<IBvbChangeBoardCard>
	{
		// Token: 0x0603626C RID: 221804 RVA: 0x00CCFB0D File Offset: 0x00CCDD0D
		public PhantomArenaBattleGuideMagicUseCardFromMonster(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0603626D RID: 221805 RVA: 0x00CCFB18 File Offset: 0x00CCDD18
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
				string message = "PhantomArenaBattleGuideMagicUseCardFromMonster invalid value";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("battleIndex", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return this.Data.BoardPosIndexList == null || this.Data.BoardPosIndexList.Contains(num + 1);
		}
	}
}
