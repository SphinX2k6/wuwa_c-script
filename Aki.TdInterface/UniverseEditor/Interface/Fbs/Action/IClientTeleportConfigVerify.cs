using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F9 RID: 25593
	public static class IClientTeleportConfigVerify
	{
		// Token: 0x0602C466 RID: 181350 RVA: 0x0061393A File Offset: 0x00611B3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
