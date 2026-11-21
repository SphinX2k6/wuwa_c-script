using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B77 RID: 31607
	public static class ITeleportToLatestResetPointDirectlyVerify
	{
		// Token: 0x06038ECB RID: 233163 RVA: 0x007B1E6A File Offset: 0x007B006A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
