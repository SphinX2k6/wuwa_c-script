using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A61 RID: 27233
	public static class IClientPreEnableSubLevelsVerify
	{
		// Token: 0x0602EB9C RID: 191388 RVA: 0x0065E680 File Offset: 0x0065C880
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

		// Token: 0x02008597 RID: 34199
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014938 RID: 84280
			public static VerifyTableAction <0>__Verify;
		}
	}
}
