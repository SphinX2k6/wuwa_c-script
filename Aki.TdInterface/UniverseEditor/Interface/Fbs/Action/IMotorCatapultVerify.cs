using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B11 RID: 27409
	public static class IMotorCatapultVerify
	{
		// Token: 0x06030155 RID: 196949 RVA: 0x00689418 File Offset: 0x00687618
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorCatapultVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorCatapultVerify.<>O.<0>__Verify = new VerifyTableAction(IMotorCatapultParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DB2 RID: 32178
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013950 RID: 80208
			public static VerifyTableAction <0>__Verify;
		}
	}
}
