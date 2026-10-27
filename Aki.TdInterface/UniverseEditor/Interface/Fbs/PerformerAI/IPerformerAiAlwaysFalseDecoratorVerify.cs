using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004356 RID: 17238
	public static class IPerformerAiAlwaysFalseDecoratorVerify
	{
		// Token: 0x060198EF RID: 104687 RVA: 0x003A8BDA File Offset: 0x003A6DDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
