using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052B2 RID: 21170
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideSelectCard : PhantomArenaBattleGuideDataBase<IBvbSelectCard>
	{
		// Token: 0x0603627D RID: 221821 RVA: 0x00CCFF52 File Offset: 0x00CCE152
		public PhantomArenaBattleGuideSelectCard(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0603627E RID: 221822 RVA: 0x00CCFF5C File Offset: 0x00CCE15C
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
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cardId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return this.Data.CardIdList == null || this.Data.CardIdList.Contains(num);
		}
	}
}
