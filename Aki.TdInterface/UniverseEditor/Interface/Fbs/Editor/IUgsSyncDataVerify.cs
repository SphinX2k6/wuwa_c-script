using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048BE RID: 18622
	public static class IUgsSyncDataVerify
	{
		// Token: 0x0601D171 RID: 119153 RVA: 0x0041B628 File Offset: 0x00419828
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
