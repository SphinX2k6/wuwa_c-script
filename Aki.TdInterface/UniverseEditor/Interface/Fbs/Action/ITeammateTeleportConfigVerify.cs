using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736C RID: 29548
	public static class ITeammateTeleportConfigVerify
	{
		// Token: 0x06035A11 RID: 219665 RVA: 0x0074D85E File Offset: 0x0074BA5E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
