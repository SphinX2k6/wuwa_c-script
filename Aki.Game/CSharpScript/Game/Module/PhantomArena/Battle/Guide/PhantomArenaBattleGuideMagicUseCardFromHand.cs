using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052AD RID: 21165
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideMagicUseCardFromHand : PhantomArenaBattleGuideDataBase<IBvbChangeHandCard>
	{
		// Token: 0x0603626A RID: 221802 RVA: 0x00CCFA82 File Offset: 0x00CCDC82
		public PhantomArenaBattleGuideMagicUseCardFromHand(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0603626B RID: 221803 RVA: 0x00CCFA8C File Offset: 0x00CCDC8C
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
				string message = "PhantomArenaBattleGuideMagicUseCardFromHand invalid value";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handIndex", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return this.Data.HandCardIndex == null || this.Data.HandCardIndex.Value - 1 == num;
		}
	}
}
