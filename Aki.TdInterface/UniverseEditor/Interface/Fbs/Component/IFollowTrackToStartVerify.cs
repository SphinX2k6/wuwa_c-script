using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052BA RID: 21178
	public static class IFollowTrackToStartVerify
	{
		// Token: 0x0602287A RID: 141434 RVA: 0x004C9236 File Offset: 0x004C7436
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
