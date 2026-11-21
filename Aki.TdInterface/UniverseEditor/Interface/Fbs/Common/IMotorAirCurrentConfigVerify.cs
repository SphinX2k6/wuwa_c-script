using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006448 RID: 25672
	public static class IMotorAirCurrentConfigVerify
	{
		// Token: 0x0602B9FD RID: 178685 RVA: 0x005F02D4 File Offset: 0x005EE4D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorAirCurrentConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorAirCurrentConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMotorAirCurrentConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMotorAirCurrentConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200851F RID: 34079
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014881 RID: 84097
			public static VerifyTableAction <0>__Verify;
		}
	}
}
