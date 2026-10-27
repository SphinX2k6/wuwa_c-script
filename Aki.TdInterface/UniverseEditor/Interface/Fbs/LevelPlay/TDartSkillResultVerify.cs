using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004604 RID: 17924
	public static class TDartSkillResultVerify
	{
		// Token: 0x0601B27E RID: 111230 RVA: 0x003DE740 File Offset: 0x003DC940
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBlockFinishRouteResultVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHitNoScoreResultVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHitPlayerLastZoneResultVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHitRemainScoreZoneResultVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHitZoneTimesResultVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IHoldBreathResultVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = INoBustResultVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ITripleZoneHitResultVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
