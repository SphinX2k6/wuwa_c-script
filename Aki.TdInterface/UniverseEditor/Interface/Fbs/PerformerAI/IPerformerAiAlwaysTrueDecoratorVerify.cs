using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004359 RID: 17241
	public static class IPerformerAiAlwaysTrueDecoratorVerify
	{
		// Token: 0x06019901 RID: 104705 RVA: 0x003A8D52 File Offset: 0x003A6F52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
