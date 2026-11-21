using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007248 RID: 29256
	public static class IMotorCatapultVerify
	{
		// Token: 0x06032F29 RID: 208681 RVA: 0x006E0AD0 File Offset: 0x006DECD0
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

		// Token: 0x02008639 RID: 34361
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A0E RID: 84494
			public static VerifyTableAction <0>__Verify;
		}
	}
}
