using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F51 RID: 16209
	public static class TBvbCardFilterVerify
	{
		// Token: 0x060160CE RID: 90318 RVA: 0x0032A75C File Offset: 0x0032895C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBvbCardFilterCheckHasBattleFactorVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBvbCardFilterCheckHasOptimalFactorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBvbCardFilterCheckIsCapableToEvolveVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBvbCardFilterCheckIsCoreVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBvbCardFilterCompareActiveSkillTagVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBvbCardFilterCompareCardTypeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBvbCardFilterCompareCostVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
