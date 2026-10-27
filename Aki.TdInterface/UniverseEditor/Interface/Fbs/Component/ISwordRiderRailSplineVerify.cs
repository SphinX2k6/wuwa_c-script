using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A15 RID: 23061
	public static class ISwordRiderRailSplineVerify
	{
		// Token: 0x06027292 RID: 160402 RVA: 0x0056307C File Offset: 0x0056127C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISwordRiderRailSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISwordRiderRailSplineVerify.<>O.<0>__Verify = new VerifyTableAction(ISwordRiderRailSplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C4D RID: 31821
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013747 RID: 79687
			public static VerifyTableAction <0>__Verify;
		}
	}
}
