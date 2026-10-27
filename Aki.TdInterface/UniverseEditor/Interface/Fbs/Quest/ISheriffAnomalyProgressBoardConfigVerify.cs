using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004111 RID: 16657
	public static class ISheriffAnomalyProgressBoardConfigVerify
	{
		// Token: 0x0601864C RID: 99916 RVA: 0x00384EAE File Offset: 0x003830AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
