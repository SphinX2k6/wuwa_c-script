using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004114 RID: 16660
	public static class ISheriffClueDetailBoardConfigVerify
	{
		// Token: 0x06018659 RID: 99929 RVA: 0x00384FA6 File Offset: 0x003831A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
