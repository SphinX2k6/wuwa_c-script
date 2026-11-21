using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200482C RID: 18476
	public static class ISeasonRotationOccupationDataVerify
	{
		// Token: 0x0601B59E RID: 112030 RVA: 0x003DFCBA File Offset: 0x003DDEBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
