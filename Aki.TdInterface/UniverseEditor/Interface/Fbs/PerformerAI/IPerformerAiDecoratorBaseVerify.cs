using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004365 RID: 17253
	public static class IPerformerAiDecoratorBaseVerify
	{
		// Token: 0x0601996D RID: 104813 RVA: 0x003A9942 File Offset: 0x003A7B42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
