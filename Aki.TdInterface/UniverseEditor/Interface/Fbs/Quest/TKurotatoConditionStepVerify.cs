using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DD RID: 17117
	public static class TKurotatoConditionStepVerify
	{
		// Token: 0x0601963A RID: 103994 RVA: 0x003A448C File Offset: 0x003A268C
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
