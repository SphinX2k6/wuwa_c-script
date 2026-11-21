using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200493A RID: 18746
	public static class IHitNoScoreResultVerify
	{
		// Token: 0x0601BD24 RID: 113956 RVA: 0x003EE732 File Offset: 0x003EC932
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
