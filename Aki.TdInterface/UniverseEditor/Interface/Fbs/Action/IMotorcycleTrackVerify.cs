using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1A RID: 27418
	public static class IMotorcycleTrackVerify
	{
		// Token: 0x060301FD RID: 197117 RVA: 0x0068AA60 File Offset: 0x00688C60
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

		// Token: 0x02007DB4 RID: 32180
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013952 RID: 80210
			public static VerifyTableAction <0>__Verify;
		}
	}
}
