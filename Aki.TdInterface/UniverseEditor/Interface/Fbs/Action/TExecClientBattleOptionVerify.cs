using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C1 RID: 30401
	public static class TExecClientBattleOptionVerify
	{
		// Token: 0x060374C5 RID: 226501 RVA: 0x0077E084 File Offset: 0x0077C284
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
				result = IMonsterNpcInteractVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IRoboSoldierSpecialTriggerHookSkillVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ITriggerHookPointSkillVerify.Verify(verifier, tablePos);
				break;
			case 10:
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
