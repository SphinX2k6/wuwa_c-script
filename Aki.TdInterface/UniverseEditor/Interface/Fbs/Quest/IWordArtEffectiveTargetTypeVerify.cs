using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A6 RID: 17062
	public static class IWordArtEffectiveTargetTypeVerify
	{
		// Token: 0x06019488 RID: 103560 RVA: 0x003A1692 File Offset: 0x0039F892
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
