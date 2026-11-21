using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007988 RID: 31112
	public static class IStartMotorCruiseVerify
	{
		// Token: 0x06036CD3 RID: 224467 RVA: 0x00754824 File Offset: 0x00752A24
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

		// Token: 0x02008706 RID: 34566
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B26 RID: 84774
			public static VerifyTableAction <0>__Verify;
		}
	}
}
