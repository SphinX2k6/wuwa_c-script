using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079FA RID: 31226
	public static class ISubtitleStyleBaseVerify
	{
		// Token: 0x06037063 RID: 225379 RVA: 0x0075AED6 File Offset: 0x007590D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
