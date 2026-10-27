using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052AA RID: 21162
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaBattleGuideEndTime : PhantomArenaBattleGuideDataBase<IBvbEndTurn>
	{
		// Token: 0x06036263 RID: 221795 RVA: 0x00CCF800 File Offset: 0x00CCDA00
		public PhantomArenaBattleGuideEndTime(EBvbPlayerOperationType type, BvbPlayerOperationConstraint param) : base(type, param)
		{
		}

		// Token: 0x06036264 RID: 221796 RVA: 0x00CCF80A File Offset: 0x00CCDA0A
		public override bool CheckCanExecute(params object[] params_)
		{
			return true;
		}
	}
}
