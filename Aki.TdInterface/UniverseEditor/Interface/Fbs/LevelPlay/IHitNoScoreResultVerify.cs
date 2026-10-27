using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044D2 RID: 17618
	public static class IHitNoScoreResultVerify
	{
		// Token: 0x0601A553 RID: 107859 RVA: 0x003C2526 File Offset: 0x003C0726
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
