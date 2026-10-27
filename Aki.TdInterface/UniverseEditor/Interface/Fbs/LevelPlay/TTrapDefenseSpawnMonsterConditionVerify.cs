using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200461F RID: 17951
	public static class TTrapDefenseSpawnMonsterConditionVerify
	{
		// Token: 0x0601B314 RID: 111380 RVA: 0x003DF630 File Offset: 0x003DD830
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
