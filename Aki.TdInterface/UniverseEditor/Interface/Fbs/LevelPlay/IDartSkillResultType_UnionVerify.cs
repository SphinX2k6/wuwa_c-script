using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048FB RID: 18683
	public static class IDartSkillResultType_UnionVerify
	{
		// Token: 0x0601BACA RID: 113354 RVA: 0x003E9874 File Offset: 0x003E7A74
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDartSkillResultTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INoBustResultVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHitZoneTimesResultVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHitRemainScoreZoneResultVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHitNoScoreResultVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITripleZoneHitResultVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IHitPlayerLastZoneResultVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBlockFinishRouteResultVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IHoldBreathResultVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
