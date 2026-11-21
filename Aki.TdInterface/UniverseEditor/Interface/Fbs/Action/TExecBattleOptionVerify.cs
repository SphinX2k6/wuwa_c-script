using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ECC RID: 32460
	public static class TExecBattleOptionVerify
	{
		// Token: 0x0603A95C RID: 239964 RVA: 0x007E2050 File Offset: 0x007E0250
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAiAssistCharacterMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAiAssistCharacterStopMoveToPointVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IExitMonsterMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IExitMonsterMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISendBattleEventsVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISendBattleEventsForMonsterSummonVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ISetBattleTagsVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ISetMonsterMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ISetMonsterMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
