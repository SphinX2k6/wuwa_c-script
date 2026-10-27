using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB2 RID: 15282
	public static class IShowTimelineCastSkillVerify
	{
		// Token: 0x06014F42 RID: 85826 RVA: 0x00309CA8 File Offset: 0x00307EA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
