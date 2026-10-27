using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD4 RID: 27860
	public static class IPlaceholderCollectibleMarkerTypeVerify
	{
		// Token: 0x060311A8 RID: 201128 RVA: 0x006A9B36 File Offset: 0x006A7D36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
