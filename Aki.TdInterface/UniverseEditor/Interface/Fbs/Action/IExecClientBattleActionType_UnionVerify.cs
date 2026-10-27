using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670D RID: 26381
	public static class IExecClientBattleActionType_UnionVerify
	{
		// Token: 0x0602DE2C RID: 187948 RVA: 0x00646484 File Offset: 0x00644684
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExecClientBattleActionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientSendTagEventToControlCharacterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITriggerHookPointSkillVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITriggerMotorSkillVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFollowShooterSkillSkillVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IClientGroupAiCommunicateVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IChangeAnimalEmotionBubbleVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IMonsterNpcInteractVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IRoboSoldierSpecialTriggerHookSkillVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IAssistCharacterMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IAssistCharacterStopMoveToPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
