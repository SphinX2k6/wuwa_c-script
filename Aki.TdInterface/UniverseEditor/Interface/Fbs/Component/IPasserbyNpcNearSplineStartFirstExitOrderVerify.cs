using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9E RID: 23710
	public static class IPasserbyNpcNearSplineStartFirstExitOrderVerify
	{
		// Token: 0x06027548 RID: 161096 RVA: 0x00562646 File Offset: 0x00560846
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
