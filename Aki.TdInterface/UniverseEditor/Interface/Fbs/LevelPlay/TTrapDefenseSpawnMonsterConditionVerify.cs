using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A87 RID: 19079
	public static class TTrapDefenseSpawnMonsterConditionVerify
	{
		// Token: 0x0601CAE9 RID: 117481 RVA: 0x0040B8CC File Offset: 0x00409ACC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrapDefenseSpawnMonsterConditionCompletedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrapDefenseSpawnMonsterConditionOpenVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
