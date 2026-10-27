using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007393 RID: 29587
	public static class ITeleportToLatestResetPointTypeVerify
	{
		// Token: 0x06035B42 RID: 219970 RVA: 0x0074FAA2 File Offset: 0x0074DCA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
