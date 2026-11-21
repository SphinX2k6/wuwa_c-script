using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DE RID: 29662
	public static class IPerceptionNotifyGatherToPlayerVerify
	{
		// Token: 0x06033E47 RID: 212551 RVA: 0x006FF56A File Offset: 0x006FD76A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
