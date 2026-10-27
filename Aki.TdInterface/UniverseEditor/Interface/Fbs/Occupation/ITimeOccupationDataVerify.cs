using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043D0 RID: 17360
	public static class ITimeOccupationDataVerify
	{
		// Token: 0x06019E51 RID: 106065 RVA: 0x003B493A File Offset: 0x003B2B3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
