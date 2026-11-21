using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC0 RID: 24000
	public static class IPulseDeviceFoundationVerify
	{
		// Token: 0x06028025 RID: 163877 RVA: 0x00578CFA File Offset: 0x00576EFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
