using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004867 RID: 18535
	public static class IEditorRestartInfoVerify
	{
		// Token: 0x0601CC2B RID: 117803 RVA: 0x00410AB0 File Offset: 0x0040ECB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
