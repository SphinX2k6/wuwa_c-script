using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412F RID: 16687
	public static class IShowUiSyntheticVerify
	{
		// Token: 0x06018785 RID: 100229 RVA: 0x00387420 File Offset: 0x00385620
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
