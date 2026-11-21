using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A79 RID: 27257
	public static class IClientTeleportConfigVerify
	{
		// Token: 0x0602EC3C RID: 191548 RVA: 0x0065F7C6 File Offset: 0x0065D9C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
