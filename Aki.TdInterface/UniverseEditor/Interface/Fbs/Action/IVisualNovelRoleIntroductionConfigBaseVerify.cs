using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DDE RID: 32222
	public static class IVisualNovelRoleIntroductionConfigBaseVerify
	{
		// Token: 0x0603A3C2 RID: 238530 RVA: 0x007D922A File Offset: 0x007D742A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
