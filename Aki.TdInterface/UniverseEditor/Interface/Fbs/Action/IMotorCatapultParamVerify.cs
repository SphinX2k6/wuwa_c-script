using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B14 RID: 27412
	public static class IMotorCatapultParamVerify
	{
		// Token: 0x06030187 RID: 196999 RVA: 0x00689B2C File Offset: 0x00687D2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorCatapultParamVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorCatapultParamVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMotorCatapultParamVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMotorCatapultParamVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMotorCatapultParamVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IMotorCatapultParamVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007DB3 RID: 32179
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013951 RID: 80209
			public static VerifyTableAction <0>__Verify;
		}
	}
}
