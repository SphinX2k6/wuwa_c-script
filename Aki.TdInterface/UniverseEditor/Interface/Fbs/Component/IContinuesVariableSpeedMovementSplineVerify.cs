using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005582 RID: 21890
	public static class IContinuesVariableSpeedMovementSplineVerify
	{
		// Token: 0x06022CB6 RID: 142518 RVA: 0x004CAC90 File Offset: 0x004C8E90
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

		// Token: 0x02008322 RID: 33570
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014540 RID: 83264
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014541 RID: 83265
			public static VerifyTableAction <1>__Verify;
		}
	}
}
