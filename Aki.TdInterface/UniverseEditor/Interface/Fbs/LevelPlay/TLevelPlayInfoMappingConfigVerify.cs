using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A72 RID: 19058
	public static class TLevelPlayInfoMappingConfigVerify
	{
		// Token: 0x0601CA73 RID: 117363 RVA: 0x0040AD3C File Offset: 0x00408F3C
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
