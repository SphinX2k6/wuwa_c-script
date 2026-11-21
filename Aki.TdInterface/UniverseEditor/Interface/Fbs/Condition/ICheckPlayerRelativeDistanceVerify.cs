using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD9 RID: 20441
	public static class ICheckPlayerRelativeDistanceVerify
	{
		// Token: 0x0601FE2F RID: 130607 RVA: 0x0046D998 File Offset: 0x0046BB98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPlayerRelativeDistanceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerRelativeDistanceVerify.<>O.<0>__Verify = new VerifyTableAction(IDistanceRangeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008295 RID: 33429
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014478 RID: 83064
			public static VerifyTableAction <0>__Verify;
		}
	}
}
