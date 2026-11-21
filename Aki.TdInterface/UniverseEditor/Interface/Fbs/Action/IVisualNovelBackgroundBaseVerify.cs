using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D51 RID: 32081
	public static class IVisualNovelBackgroundBaseVerify
	{
		// Token: 0x06039EA1 RID: 237217 RVA: 0x007CFA0E File Offset: 0x007CDC0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
