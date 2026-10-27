using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004156 RID: 16726
	public static class ISurvivorsRougeConditionStepBase_UnionVerify
	{
		// Token: 0x0601890F RID: 100623 RVA: 0x0038A580 File Offset: 0x00388780
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISurvivorsRougeConditionStepBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISurvivorsRougeConditionStepPrepareVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISurvivorsRougeConditionStepBattleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISurvivorsRougeConditionStepEndVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISurvivorsRougeConditionStepChestRewardVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISurvivorsRougeConditionStepChooseWeaponVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ISurvivorsRougeConditionStepChooseItemVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ISurvivorsRougeConditionStepShoppingVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
