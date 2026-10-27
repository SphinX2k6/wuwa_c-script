using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B4F RID: 15183
	public static class TBvbCardFilterVerify
	{
		// Token: 0x06014C24 RID: 85028 RVA: 0x003044CC File Offset: 0x003026CC
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
