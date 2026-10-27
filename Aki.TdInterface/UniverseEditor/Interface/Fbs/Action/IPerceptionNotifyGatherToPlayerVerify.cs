using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C77 RID: 27767
	public static class IPerceptionNotifyGatherToPlayerVerify
	{
		// Token: 0x06030EEC RID: 200428 RVA: 0x006A506A File Offset: 0x006A326A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
