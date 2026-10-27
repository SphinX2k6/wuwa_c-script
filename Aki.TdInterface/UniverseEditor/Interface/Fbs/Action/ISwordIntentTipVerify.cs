using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007279 RID: 29305
	public static class ISwordIntentTipVerify
	{
		// Token: 0x06033FEC RID: 212972 RVA: 0x006FDF56 File Offset: 0x006FC156
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
