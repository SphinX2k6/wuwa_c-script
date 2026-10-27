using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711D RID: 28957
	public static class ISitOnGroundVerify
	{
		// Token: 0x06033574 RID: 210292 RVA: 0x006EBA02 File Offset: 0x006E9C02
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
