using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048CA RID: 18634
	public static class IWorldEditorTemplateConfigVerify
	{
		// Token: 0x0601D239 RID: 119353 RVA: 0x0041D280 File Offset: 0x0041B480
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
