using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E1A RID: 32282
	public static class IWindProtagonistParkour2Verify
	{
		// Token: 0x0603A56A RID: 238954 RVA: 0x007DBC1A File Offset: 0x007D9E1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
