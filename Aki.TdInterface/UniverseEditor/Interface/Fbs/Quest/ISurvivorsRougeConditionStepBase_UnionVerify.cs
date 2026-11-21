using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200459A RID: 17818
	public static class ISurvivorsRougeConditionStepBase_UnionVerify
	{
		// Token: 0x06019FD7 RID: 106455 RVA: 0x003B4B3C File Offset: 0x003B2D3C
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
