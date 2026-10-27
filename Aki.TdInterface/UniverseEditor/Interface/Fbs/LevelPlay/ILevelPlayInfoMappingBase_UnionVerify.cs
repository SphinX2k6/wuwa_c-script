using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044F6 RID: 17654
	public static class ILevelPlayInfoMappingBase_UnionVerify
	{
		// Token: 0x0601A7E6 RID: 108518 RVA: 0x003C8CB4 File Offset: 0x003C6EB4
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
