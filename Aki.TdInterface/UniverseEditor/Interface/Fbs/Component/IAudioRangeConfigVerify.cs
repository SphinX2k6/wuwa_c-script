using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540B RID: 21515
	public static class IAudioRangeConfigVerify
	{
		// Token: 0x06021A62 RID: 137826 RVA: 0x004A3625 File Offset: 0x004A1825
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
