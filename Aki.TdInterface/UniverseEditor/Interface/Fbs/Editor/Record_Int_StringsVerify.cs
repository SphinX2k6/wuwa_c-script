using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048DC RID: 18652
	public static class Record_Int_StringsVerify
	{
		// Token: 0x0601D2CB RID: 119499 RVA: 0x0041E2BB File Offset: 0x0041C4BB
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
