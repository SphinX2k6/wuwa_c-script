using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004790 RID: 18320
	public static class TTrapDefenseConditionStepVerify
	{
		// Token: 0x0601AF9C RID: 110492 RVA: 0x003D2CBC File Offset: 0x003D0EBC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrapDefenseConditionStepLoadAndRestoreMapVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrapDefenseConditionStepMapChangeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrapDefenseConditionStepPreviewVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITrapDefenseConditionStepRewardVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITrapDefenseConditionStepSpawnMonsterVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
