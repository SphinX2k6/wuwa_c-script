using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E29 RID: 32297
	public static class IWriteLetterConfigVerify
	{
		// Token: 0x0603A5C8 RID: 239048 RVA: 0x007DC3FA File Offset: 0x007DA5FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
