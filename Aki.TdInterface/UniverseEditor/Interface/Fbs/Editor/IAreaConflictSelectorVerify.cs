using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200481F RID: 18463
	public static class IAreaConflictSelectorVerify
	{
		// Token: 0x0601C844 RID: 116804 RVA: 0x004086CE File Offset: 0x004068CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
