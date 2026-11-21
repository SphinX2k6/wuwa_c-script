using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB0 RID: 23728
	public static class IPasserbyNpcRideLiftLeaveOnArrivalMoveVerify
	{
		// Token: 0x06027600 RID: 161280 RVA: 0x00563DB8 File Offset: 0x00561FB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcRideLiftLeaveOnArrivalMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcRideLiftLeaveOnArrivalMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcLiftStopExitTimingVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPasserbyNpcRideLiftLeaveOnArrivalMoveVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPasserbyNpcRideLiftLeaveOnArrivalMoveVerify.<>O.<1>__Verify = new VerifyTableAction(IPasserbyNpcFloorSplineVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008434 RID: 33844
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014715 RID: 83733
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014716 RID: 83734
			public static VerifyTableAction <1>__Verify;
		}
	}
}
