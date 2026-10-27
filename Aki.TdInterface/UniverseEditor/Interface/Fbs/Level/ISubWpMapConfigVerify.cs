using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200441A RID: 17434
	public static class ISubWpMapConfigVerify
	{
		// Token: 0x06019F81 RID: 106369 RVA: 0x003B6A54 File Offset: 0x003B4C54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
