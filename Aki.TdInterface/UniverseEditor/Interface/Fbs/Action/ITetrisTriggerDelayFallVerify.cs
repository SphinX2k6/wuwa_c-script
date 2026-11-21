using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BB6 RID: 31670
	public static class ITetrisTriggerDelayFallVerify
	{
		// Token: 0x06039132 RID: 233778 RVA: 0x007B6C6A File Offset: 0x007B4E6A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
