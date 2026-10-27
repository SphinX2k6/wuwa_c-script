using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052B0 RID: 21168
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideRecycleCardFromHand : PhantomArenaBattleGuideDataBase<IBvbRecycleHandCard>
	{
		// Token: 0x06036279 RID: 221817 RVA: 0x00CCFE44 File Offset: 0x00CCE044
		public PhantomArenaBattleGuideRecycleCardFromHand(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0603627A RID: 221818 RVA: 0x00CCFE50 File Offset: 0x00CCE050
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
