using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047F9 RID: 18425
	public static class IClosedSegmentOccupationDataVerify
	{
		// Token: 0x0601B380 RID: 111488 RVA: 0x003DB50A File Offset: 0x003D970A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
