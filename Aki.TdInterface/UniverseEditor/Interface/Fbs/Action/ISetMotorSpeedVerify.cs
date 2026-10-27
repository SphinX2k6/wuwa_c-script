using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007021 RID: 28705
	public static class ISetMotorSpeedVerify
	{
		// Token: 0x06032C6A RID: 207978 RVA: 0x006D9948 File Offset: 0x006D7B48
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

		// Token: 0x02007E41 RID: 32321
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A0B RID: 80395
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A0C RID: 80396
			public static VerifyTableAction <1>__Verify;
		}
	}
}
