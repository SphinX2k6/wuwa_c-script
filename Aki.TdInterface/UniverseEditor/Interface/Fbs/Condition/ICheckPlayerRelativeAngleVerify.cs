using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AFB RID: 19195
	public static class ICheckPlayerRelativeAngleVerify
	{
		// Token: 0x0601E2CE RID: 123598 RVA: 0x0043B468 File Offset: 0x00439668
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPlayerRelativeAngleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerRelativeAngleVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICheckPlayerRelativeAngleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckPlayerRelativeAngleVerify.<>O.<1>__Verify = new VerifyTableAction(IAngleRangeVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A43 RID: 31299
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013407 RID: 78855
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013408 RID: 78856
			public static VerifyTableAction <1>__Verify;
		}
	}
}
