using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE7 RID: 24039
	public static class IRandomBatchPoolRefreshVerify
	{
		// Token: 0x060281E3 RID: 164323 RVA: 0x0057CAD0 File Offset: 0x0057ACD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomBatchPoolRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomBatchPoolRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListBatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008465 RID: 33893
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014764 RID: 83812
			public static VerifyTableAction <0>__Verify;
		}
	}
}
