using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CCC RID: 19660
	public static class IEditorRestartInfoVerify
	{
		// Token: 0x0601E41C RID: 123932 RVA: 0x0043D358 File Offset: 0x0043B558
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
