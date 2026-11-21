using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E07 RID: 15879
	public static class IBvbCardFilterBase_UnionVerify
	{
		// Token: 0x06015568 RID: 87400 RVA: 0x0031542C File Offset: 0x0031362C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBvbCardFilterBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBvbCardFilterCompareCostVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBvbCardFilterCompareCardTypeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBvbCardFilterCheckIsCoreVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBvbCardFilterCompareActiveSkillTagVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBvbCardFilterCheckHasBattleFactorVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBvbCardFilterCheckHasOptimalFactorVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBvbCardFilterCheckIsCapableToEvolveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
