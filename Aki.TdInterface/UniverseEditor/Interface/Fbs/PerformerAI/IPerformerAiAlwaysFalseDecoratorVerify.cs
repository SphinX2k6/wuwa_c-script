using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047B8 RID: 18360
	public static class IPerformerAiAlwaysFalseDecoratorVerify
	{
		// Token: 0x0601B07D RID: 110717 RVA: 0x003D4602 File Offset: 0x003D2802
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
