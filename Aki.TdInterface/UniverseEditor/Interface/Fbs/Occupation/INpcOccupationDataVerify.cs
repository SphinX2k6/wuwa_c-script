using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043AC RID: 17324
	public static class INpcOccupationDataVerify
	{
		// Token: 0x06019CB9 RID: 105657 RVA: 0x003B147A File Offset: 0x003AF67A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
