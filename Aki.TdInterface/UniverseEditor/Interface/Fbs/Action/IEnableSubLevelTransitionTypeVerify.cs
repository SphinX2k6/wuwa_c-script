using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200668C RID: 26252
	public static class IEnableSubLevelTransitionTypeVerify
	{
		// Token: 0x0602DA04 RID: 186884 RVA: 0x0063EC22 File Offset: 0x0063CE22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
