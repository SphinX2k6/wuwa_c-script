using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005023 RID: 20515
	public static class IContinuesVariableSpeedMovementSplineVerify
	{
		// Token: 0x06020D96 RID: 134550 RVA: 0x00491240 File Offset: 0x0048F440
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IContinuesVariableSpeedMovementSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IContinuesVariableSpeedMovementSplineVerify.<>O.<0>__Verify = new VerifyTableAction(ITimePathConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IContinuesVariableSpeedMovementSplineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IContinuesVariableSpeedMovementSplineVerify.<>O.<1>__Verify = new VerifyTableAction(IContinuesVariableSpeedSplinePointVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AC8 RID: 31432
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134C2 RID: 79042
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134C3 RID: 79043
			public static VerifyTableAction <1>__Verify;
		}
	}
}
