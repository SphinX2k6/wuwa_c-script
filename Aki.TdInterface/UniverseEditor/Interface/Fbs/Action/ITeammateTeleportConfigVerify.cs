using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B4D RID: 31565
	public static class ITeammateTeleportConfigVerify
	{
		// Token: 0x06038D8A RID: 232842 RVA: 0x007AFA9A File Offset: 0x007ADC9A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
