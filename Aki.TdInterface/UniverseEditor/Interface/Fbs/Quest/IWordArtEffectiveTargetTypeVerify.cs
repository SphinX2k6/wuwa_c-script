using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004702 RID: 18178
	public static class IWordArtEffectiveTargetTypeVerify
	{
		// Token: 0x0601ABF4 RID: 109556 RVA: 0x003CCD6A File Offset: 0x003CAF6A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
