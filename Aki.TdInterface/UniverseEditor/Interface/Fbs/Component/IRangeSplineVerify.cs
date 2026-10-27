using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580A RID: 22538
	public static class IRangeSplineVerify
	{
		// Token: 0x06025E46 RID: 155206 RVA: 0x00539BF4 File Offset: 0x00537DF4
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

		// Token: 0x02007BFF RID: 31743
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136D0 RID: 79568
			public static VerifyTableAction <0>__Verify;
		}
	}
}
