using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004727 RID: 18215
	public static class TDarkTideBossEventVerify
	{
		// Token: 0x0601AD40 RID: 109888 RVA: 0x003CF1A8 File Offset: 0x003CD3A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDarkTideChonglouTrialBossEventVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDarkTideHaiweixiaArenaBossEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDarkTideHecatePollutionBossEventVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDarkTideMechaAssemblyBossEventVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IDarkTideWyvernPositionBossEventVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IDarkTideXinjilemuChaseBossEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
