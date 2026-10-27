using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007441 RID: 29761
	public static class ITransitionPopupArtTextTypeBaseVerify
	{
		// Token: 0x06036113 RID: 221459 RVA: 0x0075A83E File Offset: 0x00758A3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
