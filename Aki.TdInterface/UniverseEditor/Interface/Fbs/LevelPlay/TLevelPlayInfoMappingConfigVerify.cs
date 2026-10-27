using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200460A RID: 17930
	public static class TLevelPlayInfoMappingConfigVerify
	{
		// Token: 0x0601B29E RID: 111262 RVA: 0x003DEAA0 File Offset: 0x003DCCA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILevelPlayInfoMappingNightmareSpawnPointVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILevelPlayInfoMappingPunishReportVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILevelPlayInfoMappingSoaringChallengeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
