using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B9 RID: 22457
	public static class IPulseDeviceFoundationVerify
	{
		// Token: 0x06025B05 RID: 154373 RVA: 0x00532B6E File Offset: 0x00530D6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
