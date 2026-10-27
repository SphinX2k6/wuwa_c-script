using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040C0 RID: 16576
	public static class IRoleTowerChallengeTitleCurrentFloorVerify
	{
		// Token: 0x0601826D RID: 98925 RVA: 0x0037B17A File Offset: 0x0037937A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
