using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200495E RID: 18782
	public static class ILevelPlayInfoMappingBase_UnionVerify
	{
		// Token: 0x0601BFBB RID: 114619 RVA: 0x003F4F50 File Offset: 0x003F3150
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILevelPlayInfoMappingBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILevelPlayInfoMappingPunishReportVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILevelPlayInfoMappingSoaringChallengeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILevelPlayInfoMappingNightmareSpawnPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
