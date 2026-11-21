using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x02004280 RID: 17024
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideRecycleCardFromHand : PhantomArenaBattleGuideDataBase<IBvbRecycleHandCard>
	{
		// Token: 0x0602B174 RID: 176500 RVA: 0x00C1D56C File Offset: 0x00C1B76C
		public PhantomArenaBattleGuideRecycleCardFromHand(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0602B175 RID: 176501 RVA: 0x00C1D578 File Offset: 0x00C1B778
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
				string message = "PhantomArenaBattleGuideRecycleCardFromHand invalid value";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("battleIndex", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return this.Data.HandCardIndex == null || this.Data.HandCardIndex.Value - 1 == num;
		}
	}
}
