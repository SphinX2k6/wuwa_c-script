using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007791 RID: 30609
	public static class ISetBattleTagType_UnionVerify
	{
		// Token: 0x06035BAB RID: 220075 RVA: 0x00732F78 File Offset: 0x00731178
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetBattleTagTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBattleStateMonsterLandingVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBattleStateFinalMonsterLandingVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBattleStateMonsterSleepVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
