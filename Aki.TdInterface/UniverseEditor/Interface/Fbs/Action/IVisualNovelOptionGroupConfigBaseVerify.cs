using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758E RID: 30094
	public static class IVisualNovelOptionGroupConfigBaseVerify
	{
		// Token: 0x06036BE7 RID: 224231 RVA: 0x0076E7A2 File Offset: 0x0076C9A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
