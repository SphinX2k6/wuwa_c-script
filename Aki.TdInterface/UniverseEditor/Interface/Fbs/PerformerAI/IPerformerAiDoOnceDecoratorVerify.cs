using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200436B RID: 17259
	public static class IPerformerAiDoOnceDecoratorVerify
	{
		// Token: 0x06019993 RID: 104851 RVA: 0x003A9CCA File Offset: 0x003A7ECA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
