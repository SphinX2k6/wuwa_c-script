using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431C RID: 17180
	public static class TSurvivorsRougeConditionStepVerify
	{
		// Token: 0x060197B4 RID: 104372 RVA: 0x003A6A10 File Offset: 0x003A4C10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISurvivorsRougeConditionStepBattleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISurvivorsRougeConditionStepChestRewardVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISurvivorsRougeConditionStepChooseItemVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISurvivorsRougeConditionStepChooseWeaponVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISurvivorsRougeConditionStepEndVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISurvivorsRougeConditionStepPrepareVerify.Verify(verifier, tablePos);
				break;
			case 7:
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
