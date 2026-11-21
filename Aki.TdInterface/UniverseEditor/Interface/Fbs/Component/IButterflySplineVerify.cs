using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005477 RID: 21623
	public static class IButterflySplineVerify
	{
		// Token: 0x06021F90 RID: 139152 RVA: 0x004AEB64 File Offset: 0x004ACD64
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

		// Token: 0x020082EE RID: 33518
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144EF RID: 83183
			public static VerifyTableAction <0>__Verify;
		}
	}
}
