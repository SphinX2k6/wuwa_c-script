using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DE7 RID: 32231
	public static class IVisualNovelStopScreenEffectConfigBaseVerify
	{
		// Token: 0x0603A3FE RID: 238590 RVA: 0x007D97C6 File Offset: 0x007D79C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
