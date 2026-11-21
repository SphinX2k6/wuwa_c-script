using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A2D RID: 18989
	public static class ITrapDefenseSpawnMonsterConditionBase_UnionVerify
	{
		// Token: 0x0601C815 RID: 116757 RVA: 0x00406078 File Offset: 0x00404278
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
