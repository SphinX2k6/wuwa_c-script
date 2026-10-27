using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E1 RID: 25569
	public static class IClientPreEnableSubLevelsVerify
	{
		// Token: 0x0602C3C6 RID: 181190 RVA: 0x006127F4 File Offset: 0x006109F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfStrings(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientPreEnableSubLevelsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientPreEnableSubLevelsVerify.<>O.<0>__Verify = new VerifyTableAction(IEnableSubLevelTransitionWithSceneCaptureVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D21 RID: 32033
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401388C RID: 80012
			public static VerifyTableAction <0>__Verify;
		}
	}
}
