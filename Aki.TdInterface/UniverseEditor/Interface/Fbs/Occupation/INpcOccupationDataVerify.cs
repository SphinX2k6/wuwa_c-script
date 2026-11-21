using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200480E RID: 18446
	public static class INpcOccupationDataVerify
	{
		// Token: 0x0601B447 RID: 111687 RVA: 0x003DCEA2 File Offset: 0x003DB0A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
