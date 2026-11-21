using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077EA RID: 30698
	public static class ISetMotorSpeedVerify
	{
		// Token: 0x06035ED0 RID: 220880 RVA: 0x0073958C File Offset: 0x0073778C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetMotorSpeedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetMotorSpeedVerify.<>O.<0>__Verify = new VerifyTableAction(IMotorConstraintConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISetMotorSpeedVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetMotorSpeedVerify.<>O.<1>__Verify = new VerifyTableAction(ISetMotorSpeedTargetSpeedVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086D6 RID: 34518
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ADC RID: 84700
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014ADD RID: 84701
			public static VerifyTableAction <1>__Verify;
		}
	}
}
