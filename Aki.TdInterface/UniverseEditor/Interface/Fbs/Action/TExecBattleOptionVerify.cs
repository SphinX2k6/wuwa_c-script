using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BE RID: 30398
	public static class TExecBattleOptionVerify
	{
		// Token: 0x060374A9 RID: 226473 RVA: 0x0077DD98 File Offset: 0x0077BF98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExitMonsterMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IExitMonsterMoveWithSplineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISendBattleEventsVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISendBattleEventsForMonsterSummonVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISetBattleTagsVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISetMonsterMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 7:
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
