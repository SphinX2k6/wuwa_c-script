using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A70 RID: 27248
	public static class IManualOccupationsVerify
	{
		// Token: 0x0602FB95 RID: 195477 RVA: 0x0067E863 File Offset: 0x0067CA63
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
