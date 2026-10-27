using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004741 RID: 18241
	public static class IMontageConfigVerify
	{
		// Token: 0x0601C120 RID: 114976 RVA: 0x003FA268 File Offset: 0x003F8468
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
