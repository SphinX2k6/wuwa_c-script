using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED7 RID: 16087
	public static class IKurotatoConditionStepBase_UnionVerify
	{
		// Token: 0x06016C1A RID: 93210 RVA: 0x00348DC0 File Offset: 0x00346FC0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IKurotatoConditionStepBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IKurotatoConditionStepPrepareVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IKurotatoConditionStepBattleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IKurotatoConditionStepEndVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IKurotatoConditionStepSaveRoleVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IKurotatoConditionStepChestRewardVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IKurotatoConditionStepUpgradeRewardVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IKurotatoConditionStepShoppingVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IKurotatoConditionStepUpdateBatchVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
