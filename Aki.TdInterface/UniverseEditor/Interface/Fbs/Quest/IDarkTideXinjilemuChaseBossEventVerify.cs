using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004204 RID: 16900
	public static class IDarkTideXinjilemuChaseBossEventVerify
	{
		// Token: 0x0601774B RID: 96075 RVA: 0x003599D6 File Offset: 0x00357BD6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
