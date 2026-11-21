using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005402 RID: 21506
	public static class IAudioEventConfigVerify
	{
		// Token: 0x06021A1A RID: 137754 RVA: 0x004A2F65 File Offset: 0x004A1165
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
