using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200604F RID: 24655
	public static class ITeleControlDestroyConditionVerify
	{
		// Token: 0x06029A2B RID: 170539 RVA: 0x005AF3FE File Offset: 0x005AD5FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
