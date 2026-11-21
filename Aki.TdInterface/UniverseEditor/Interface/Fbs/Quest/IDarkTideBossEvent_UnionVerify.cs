using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E9 RID: 16873
	public static class IDarkTideBossEvent_UnionVerify
	{
		// Token: 0x060176AB RID: 95915 RVA: 0x00358BAC File Offset: 0x00356DAC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDarkTideBossEventVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDarkTideXinjilemuChaseBossEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDarkTideHecatePollutionBossEventVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDarkTideHaiweixiaArenaBossEventVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IDarkTideWyvernPositionBossEventVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IDarkTideChonglouTrialBossEventVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IDarkTideMechaAssemblyBossEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
