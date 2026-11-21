using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E11 RID: 24081
	public static class IRangeSplineVerify
	{
		// Token: 0x06028366 RID: 164710 RVA: 0x0057FD80 File Offset: 0x0057DF80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRangeSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRangeSplineVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonSplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200846D RID: 33901
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014770 RID: 83824
			public static VerifyTableAction <0>__Verify;
		}
	}
}
