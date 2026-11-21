using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ECF RID: 32463
	public static class TExecClientBattleOptionVerify
	{
		// Token: 0x0603A97A RID: 239994 RVA: 0x007E2388 File Offset: 0x007E0588
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAssistCharacterMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAssistCharacterStopMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IChangeAnimalEmotionBubbleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IClientGroupAiCommunicateVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IClientSendTagEventToControlCharacterVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFollowShooterSkillSkillVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IMechExecuteVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IMonsterNpcInteractVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IRoboSoldierSpecialTriggerHookSkillVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ITriggerHookPointSkillVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ITriggerMotorSkillVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
