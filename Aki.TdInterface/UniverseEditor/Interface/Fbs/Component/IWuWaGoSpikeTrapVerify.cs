using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDB RID: 23515
	public static class IWuWaGoSpikeTrapVerify
	{
		// Token: 0x060284C8 RID: 165064 RVA: 0x005897A4 File Offset: 0x005879A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 2UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
