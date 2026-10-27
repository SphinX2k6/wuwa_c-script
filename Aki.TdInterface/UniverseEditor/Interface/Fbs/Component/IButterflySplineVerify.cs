using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F48 RID: 20296
	public static class IButterflySplineVerify
	{
		// Token: 0x0602023E RID: 131646 RVA: 0x00478B74 File Offset: 0x00476D74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IButterflySplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IButterflySplineVerify.<>O.<0>__Verify = new VerifyTableAction(IButterflySplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A98 RID: 31384
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013479 RID: 78969
			public static VerifyTableAction <0>__Verify;
		}
	}
}
