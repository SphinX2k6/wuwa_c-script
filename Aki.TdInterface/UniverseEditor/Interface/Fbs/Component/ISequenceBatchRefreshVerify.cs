using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F09 RID: 24329
	public static class ISequenceBatchRefreshVerify
	{
		// Token: 0x06028D51 RID: 167249 RVA: 0x0059496C File Offset: 0x00592B6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceBatchRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceBatchRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListBatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008497 RID: 33943
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147B0 RID: 83888
			public static VerifyTableAction <0>__Verify;
		}
	}
}
