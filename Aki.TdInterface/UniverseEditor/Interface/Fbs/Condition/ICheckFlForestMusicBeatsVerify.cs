using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EEF RID: 20207
	public static class ICheckFlForestMusicBeatsVerify
	{
		// Token: 0x0601F5FB RID: 128507 RVA: 0x0045ED8F File Offset: 0x0045CF8F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
