using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A2C RID: 14892
	public static class IBvbCardFilterBase_UnionVerify
	{
		// Token: 0x0601424C RID: 82508 RVA: 0x002F2240 File Offset: 0x002F0440
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
