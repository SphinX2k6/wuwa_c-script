using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B53 RID: 31571
	public static class ITeamTypeVerify
	{
		// Token: 0x06038DA8 RID: 232872 RVA: 0x007AFD0E File Offset: 0x007ADF0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
