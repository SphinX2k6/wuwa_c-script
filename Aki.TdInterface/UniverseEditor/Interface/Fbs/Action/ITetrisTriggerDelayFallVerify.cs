using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073CF RID: 29647
	public static class ITetrisTriggerDelayFallVerify
	{
		// Token: 0x06035D97 RID: 220567 RVA: 0x0075472A File Offset: 0x0075292A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
