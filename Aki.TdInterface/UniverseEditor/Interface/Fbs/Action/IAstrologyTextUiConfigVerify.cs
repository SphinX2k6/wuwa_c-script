using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061AB RID: 25003
	public static class IAstrologyTextUiConfigVerify
	{
		// Token: 0x0602B13F RID: 176447 RVA: 0x005F0BD8 File Offset: 0x005EEDD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
