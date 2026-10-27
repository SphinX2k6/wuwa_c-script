using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B34 RID: 23348
	public static class IViewDistanceModeVerify
	{
		// Token: 0x06027E75 RID: 163445 RVA: 0x0057C996 File Offset: 0x0057AB96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
