using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047BB RID: 18363
	public static class IPerformerAiAlwaysTrueDecoratorVerify
	{
		// Token: 0x0601B08F RID: 110735 RVA: 0x003D477A File Offset: 0x003D297A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
