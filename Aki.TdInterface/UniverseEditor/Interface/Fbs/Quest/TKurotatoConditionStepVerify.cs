using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200473C RID: 18236
	public static class TKurotatoConditionStepVerify
	{
		// Token: 0x0601ADBC RID: 110012 RVA: 0x003CFDBC File Offset: 0x003CDFBC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IKurotatoConditionStepBattleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IKurotatoConditionStepChestRewardVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IKurotatoConditionStepEndVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IKurotatoConditionStepPrepareVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IKurotatoConditionStepSaveRoleVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IKurotatoConditionStepShoppingVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IKurotatoConditionStepUpdateBatchVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IKurotatoConditionStepUpgradeRewardVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
