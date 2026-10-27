using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004656 RID: 18006
	public static class IGetAllGraduatedPhantomVerify
	{
		// Token: 0x0601B49C RID: 111772 RVA: 0x003E1C2A File Offset: 0x003DFE2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
