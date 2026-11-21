using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EF RID: 16879
	public static class IDarkTideHaiweixiaArenaBossEventVerify
	{
		// Token: 0x060176CF RID: 95951 RVA: 0x00358EF6 File Offset: 0x003570F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
