using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.EditorObject
{
	// Token: 0x020048FB RID: 18683
	public static class IEditorObjectVerify
	{
		// Token: 0x0601D365 RID: 119653 RVA: 0x0041F308 File Offset: 0x0041D508
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
