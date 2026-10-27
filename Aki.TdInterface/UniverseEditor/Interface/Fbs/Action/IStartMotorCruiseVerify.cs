using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B3 RID: 29107
	public static class IStartMotorCruiseVerify
	{
		// Token: 0x060339D5 RID: 211413 RVA: 0x006F3558 File Offset: 0x006F1758
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStartMotorCruiseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStartMotorCruiseVerify.<>O.<0>__Verify = new VerifyTableAction(ISplineWayPointVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStartMotorCruiseVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IStartMotorCruiseVerify.<>O.<0>__Verify = new VerifyTableAction(ISplineWayPointVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007E6F RID: 32367
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A4F RID: 80463
			public static VerifyTableAction <0>__Verify;
		}
	}
}
