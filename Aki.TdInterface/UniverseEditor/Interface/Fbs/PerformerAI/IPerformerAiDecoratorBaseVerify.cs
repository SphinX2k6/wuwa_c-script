using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C7 RID: 18375
	public static class IPerformerAiDecoratorBaseVerify
	{
		// Token: 0x0601B0FB RID: 110843 RVA: 0x003D536A File Offset: 0x003D356A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
