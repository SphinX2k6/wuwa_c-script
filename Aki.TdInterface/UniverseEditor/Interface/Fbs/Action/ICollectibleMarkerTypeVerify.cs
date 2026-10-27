using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006450 RID: 25680
	public static class ICollectibleMarkerTypeVerify
	{
		// Token: 0x0602C71B RID: 182043 RVA: 0x006189FA File Offset: 0x00616BFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
