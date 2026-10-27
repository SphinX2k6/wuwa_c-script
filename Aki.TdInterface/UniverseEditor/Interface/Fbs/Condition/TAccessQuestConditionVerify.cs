using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D29 RID: 19753
	public static class TAccessQuestConditionVerify
	{
		// Token: 0x0601F5BD RID: 128445 RVA: 0x0045F1B4 File Offset: 0x0045D3B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDungeonQuestPreConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IExploreLevelCondtionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFeatureCollectionLevelPreConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IItemConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPreChildQuestCondtionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPreGenderCondtionVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IPreLevelPlayCondtionVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IPreQuestCondtionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IReachAreaCondtionVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ISystemStateConditonVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IOpenDateConditonVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IMapThemedActivityReachRankVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
