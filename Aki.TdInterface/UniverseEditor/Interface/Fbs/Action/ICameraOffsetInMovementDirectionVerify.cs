using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006903 RID: 26883
	public static class ICameraOffsetInMovementDirectionVerify
	{
		// Token: 0x0602E0E3 RID: 188643 RVA: 0x0064B474 File Offset: 0x00649674
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraOffsetInMovementDirectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraOffsetInMovementDirectionVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008576 RID: 34166
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401490D RID: 84237
			public static VerifyTableAction <0>__Verify;
		}
	}
}
