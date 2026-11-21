using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F34 RID: 28468
	public static class IGiantTriggerResponseVerify
	{
		// Token: 0x06031445 RID: 201797 RVA: 0x006ACBC9 File Offset: 0x006AADC9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
