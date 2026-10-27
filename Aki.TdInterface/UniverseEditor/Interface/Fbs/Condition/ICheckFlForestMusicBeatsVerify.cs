using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A2C RID: 18988
	public static class ICheckFlForestMusicBeatsVerify
	{
		// Token: 0x0601DB72 RID: 121714 RVA: 0x0042DE97 File Offset: 0x0042C097
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
