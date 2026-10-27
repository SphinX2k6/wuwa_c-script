using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200465C RID: 18012
	public static class IGmCommandVerify
	{
		// Token: 0x0601B4C0 RID: 111808 RVA: 0x003E1F1A File Offset: 0x003E011A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
