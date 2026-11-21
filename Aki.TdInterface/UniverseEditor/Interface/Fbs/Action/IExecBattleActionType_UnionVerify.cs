using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D81 RID: 28033
	public static class IExecBattleActionType_UnionVerify
	{
		// Token: 0x0603060B RID: 198155 RVA: 0x00692DB4 File Offset: 0x00690FB4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExecBattleActionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISetBattleTagsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISendBattleEventsVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISendBattleEventsForMonsterSummonVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISetMonsterMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IExitMonsterMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ISetMonsterMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IExitMonsterMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IAiAssistCharacterMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IAiAssistCharacterStopMoveToPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
