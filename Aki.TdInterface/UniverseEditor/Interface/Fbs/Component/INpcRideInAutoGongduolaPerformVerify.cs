using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE1 RID: 23521
	public static class INpcRideInAutoGongduolaPerformVerify
	{
		// Token: 0x06026D81 RID: 159105 RVA: 0x00551A5F File Offset: 0x0054FC5F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
