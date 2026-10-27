using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044FC RID: 17660
	public static class ILevelPlayInfoMappingPunishReportVerify
	{
		// Token: 0x0601A846 RID: 108614 RVA: 0x003C98CC File Offset: 0x003C7ACC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
