using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E2 RID: 30178
	public static class IVisualNovelTransitionConfigBaseVerify
	{
		// Token: 0x06036F8F RID: 225167 RVA: 0x00775B72 File Offset: 0x00773D72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
