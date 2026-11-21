using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.EditorObject
{
	// Token: 0x02004D60 RID: 19808
	public static class IEditorObjectVerify
	{
		// Token: 0x0601EB52 RID: 125778 RVA: 0x0044BAA4 File Offset: 0x00449CA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
