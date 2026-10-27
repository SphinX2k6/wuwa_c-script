using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004858 RID: 18520
	public static class IEditorArgConfigVerify
	{
		// Token: 0x0601CAE3 RID: 117475 RVA: 0x0040DD00 File Offset: 0x0040BF00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
