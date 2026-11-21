using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005819 RID: 22553
	public static class IFollowTrackEndTypeVerify
	{
		// Token: 0x060247EA RID: 149482 RVA: 0x00503AE2 File Offset: 0x00501CE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
