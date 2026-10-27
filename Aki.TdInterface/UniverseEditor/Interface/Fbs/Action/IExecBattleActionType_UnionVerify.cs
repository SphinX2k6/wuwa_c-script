using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006701 RID: 26369
	public static class IExecBattleActionType_UnionVerify
	{
		// Token: 0x0602DDC8 RID: 187848 RVA: 0x00645728 File Offset: 0x00643928
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
