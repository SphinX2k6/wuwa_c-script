using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004708 RID: 18184
	public static class IRunningNodeStatusVerify
	{
		// Token: 0x0601BE38 RID: 114232 RVA: 0x003F3DF4 File Offset: 0x003F1FF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
