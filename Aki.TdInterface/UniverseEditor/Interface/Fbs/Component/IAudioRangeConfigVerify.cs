using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EDC RID: 20188
	public static class IAudioRangeConfigVerify
	{
		// Token: 0x0601FD1E RID: 130334 RVA: 0x0046D855 File Offset: 0x0046BA55
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
