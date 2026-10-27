using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755B RID: 30043
	public static class IVisualNovelBackgroundBaseVerify
	{
		// Token: 0x06036A8B RID: 223883 RVA: 0x0076C766 File Offset: 0x0076A966
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
