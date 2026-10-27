using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C5 RID: 17861
	public static class ITrapDefenseSpawnMonsterConditionBase_UnionVerify
	{
		// Token: 0x0601B040 RID: 110656 RVA: 0x003D9DDC File Offset: 0x003D7FDC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrapDefenseSpawnMonsterConditionBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrapDefenseSpawnMonsterConditionCompletedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrapDefenseSpawnMonsterConditionOpenVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
