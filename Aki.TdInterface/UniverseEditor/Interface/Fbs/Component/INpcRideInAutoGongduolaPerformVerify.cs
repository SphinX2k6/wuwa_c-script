using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005643 RID: 22083
	public static class INpcRideInAutoGongduolaPerformVerify
	{
		// Token: 0x06024B62 RID: 150370 RVA: 0x0051113B File Offset: 0x0050F33B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
