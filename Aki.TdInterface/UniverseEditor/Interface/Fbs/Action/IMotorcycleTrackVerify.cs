using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007251 RID: 29265
	public static class IMotorcycleTrackVerify
	{
		// Token: 0x06032FD1 RID: 208849 RVA: 0x006E2118 File Offset: 0x006E0318
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyString(tablePos, 26, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 32, false))
			{
				short offsetId = 34;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorcycleTrackVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorcycleTrackVerify.<>O.<0>__Verify = new VerifyTableAction(IAutomaticDriveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 36, 2UL, 2UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200863B RID: 34363
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A10 RID: 84496
			public static VerifyTableAction <0>__Verify;
		}
	}
}
