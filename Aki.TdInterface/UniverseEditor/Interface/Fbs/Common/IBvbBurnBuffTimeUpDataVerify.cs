using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200637F RID: 25471
	public static class IBvbBurnBuffTimeUpDataVerify
	{
		// Token: 0x0602B407 RID: 177159 RVA: 0x005E5F2A File Offset: 0x005E412A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
