using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D8D RID: 32141
	public static class IVisualNovelOptionGroupNormalVerify
	{
		// Token: 0x0603A041 RID: 237633 RVA: 0x007D217E File Offset: 0x007D037E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
