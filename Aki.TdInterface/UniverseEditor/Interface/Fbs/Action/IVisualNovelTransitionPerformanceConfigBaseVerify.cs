using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075EB RID: 30187
	public static class IVisualNovelTransitionPerformanceConfigBaseVerify
	{
		// Token: 0x06036FCD RID: 225229 RVA: 0x0077614A File Offset: 0x0077434A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
