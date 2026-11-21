using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004552 RID: 17746
	public static class ISheriffAnomalyProgressBoardConfigVerify
	{
		// Token: 0x06019CEF RID: 105711 RVA: 0x003AEEB6 File Offset: 0x003AD0B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
