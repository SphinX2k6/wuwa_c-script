using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004720 RID: 18208
	public static class ITestCaseVerify
	{
		// Token: 0x0601BF7E RID: 114558 RVA: 0x003F6B10 File Offset: 0x003F4D10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyVectorOfStrings(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
