using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004835 RID: 18485
	public static class ITimeOccupationDataVerify
	{
		// Token: 0x0601B5FE RID: 112126 RVA: 0x003E074A File Offset: 0x003DE94A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
