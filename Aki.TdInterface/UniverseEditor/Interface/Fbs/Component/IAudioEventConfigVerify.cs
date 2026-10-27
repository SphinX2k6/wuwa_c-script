using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ED3 RID: 20179
	public static class IAudioEventConfigVerify
	{
		// Token: 0x0601FCD6 RID: 130262 RVA: 0x0046D195 File Offset: 0x0046B395
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
