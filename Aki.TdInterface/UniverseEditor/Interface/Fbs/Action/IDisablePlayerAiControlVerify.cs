using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5B RID: 27739
	public static class IDisablePlayerAiControlVerify
	{
		// Token: 0x0602FC63 RID: 195683 RVA: 0x00681C2E File Offset: 0x0067FE2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
