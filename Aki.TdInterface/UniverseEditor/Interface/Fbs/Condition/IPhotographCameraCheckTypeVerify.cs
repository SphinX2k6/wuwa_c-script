using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005174 RID: 20852
	public static class IPhotographCameraCheckTypeVerify
	{
		// Token: 0x06020CEE RID: 134382 RVA: 0x0048ABA2 File Offset: 0x00488DA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
