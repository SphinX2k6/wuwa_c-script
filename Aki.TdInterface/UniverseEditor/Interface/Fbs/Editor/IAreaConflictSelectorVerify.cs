using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C87 RID: 19591
	public static class IAreaConflictSelectorVerify
	{
		// Token: 0x0601E041 RID: 122945 RVA: 0x0043501E File Offset: 0x0043321E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
