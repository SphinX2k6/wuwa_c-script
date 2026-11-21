using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x0200427A RID: 17018
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideEndTime : PhantomArenaBattleGuideDataBase<IBvbEndTurn>
	{
		// Token: 0x0602B15E RID: 176478 RVA: 0x00C1CF28 File Offset: 0x00C1B128
		public PhantomArenaBattleGuideEndTime(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x0602B15F RID: 176479 RVA: 0x00C1CF32 File Offset: 0x00C1B132
		public override bool CheckCanExecute(params object[] params_)
		{
			return true;
		}
	}
}
