using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DEA RID: 24042
	public static class IRandomBatchRefreshVerify
	{
		// Token: 0x060281FF RID: 164351 RVA: 0x0057CE9C File Offset: 0x0057B09C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomBatchRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomBatchRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListBatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008466 RID: 33894
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014765 RID: 83813
			public static VerifyTableAction <0>__Verify;
		}
	}
}
