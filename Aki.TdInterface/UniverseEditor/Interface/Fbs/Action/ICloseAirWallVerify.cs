using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A94 RID: 27284
	public static class ICloseAirWallVerify
	{
		// Token: 0x0602ED22 RID: 191778 RVA: 0x0066172E File Offset: 0x0065F92E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
