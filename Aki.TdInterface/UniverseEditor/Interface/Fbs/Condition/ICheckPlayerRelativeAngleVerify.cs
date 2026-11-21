using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD6 RID: 20438
	public static class ICheckPlayerRelativeAngleVerify
	{
		// Token: 0x0601FE0F RID: 130575 RVA: 0x0046D514 File Offset: 0x0046B714
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

		// Token: 0x02008294 RID: 33428
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014476 RID: 83062
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014477 RID: 83063
			public static VerifyTableAction <1>__Verify;
		}
	}
}
