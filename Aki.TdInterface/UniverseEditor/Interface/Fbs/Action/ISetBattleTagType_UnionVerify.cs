using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC8 RID: 28616
	public static class ISetBattleTagType_UnionVerify
	{
		// Token: 0x06032945 RID: 207173 RVA: 0x006D3334 File Offset: 0x006D1534
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
