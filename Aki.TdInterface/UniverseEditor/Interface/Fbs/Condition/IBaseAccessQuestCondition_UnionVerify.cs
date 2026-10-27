using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004972 RID: 18802
	public static class IBaseAccessQuestCondition_UnionVerify
	{
		// Token: 0x0601D4EB RID: 120043 RVA: 0x00422350 File Offset: 0x00420550
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBaseAccessQuestConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IExploreLevelCondtionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPreQuestCondtionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPreChildQuestCondtionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IItemConditionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPreLevelPlayCondtionVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IPreGenderCondtionVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IReachAreaCondtionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IOpenDateConditonVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ISystemStateConditonVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IDungeonQuestPreConditionVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IFeatureCollectionLevelPreConditionVerify.Verify(verifier, tablePos);
				break;
			case 13:
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
