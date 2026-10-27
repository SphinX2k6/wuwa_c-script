using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432E RID: 17198
	public static class TTrapDefenseConditionStepVerify
	{
		// Token: 0x0601980E RID: 104462 RVA: 0x003A7294 File Offset: 0x003A5494
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
