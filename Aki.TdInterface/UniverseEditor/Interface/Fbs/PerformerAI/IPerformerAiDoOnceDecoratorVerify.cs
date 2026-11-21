using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047CD RID: 18381
	public static class IPerformerAiDoOnceDecoratorVerify
	{
		// Token: 0x0601B121 RID: 110881 RVA: 0x003D56F2 File Offset: 0x003D38F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
