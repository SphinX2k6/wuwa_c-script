using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006417 RID: 25623
	public static class ICloseBrokenRockVerify
	{
		// Token: 0x0602C55E RID: 181598 RVA: 0x00615A1A File Offset: 0x00613C1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
