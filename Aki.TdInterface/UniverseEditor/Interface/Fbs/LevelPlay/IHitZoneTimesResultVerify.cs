using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044DB RID: 17627
	public static class IHitZoneTimesResultVerify
	{
		// Token: 0x0601A5A9 RID: 107945 RVA: 0x003C300D File Offset: 0x003C120D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
