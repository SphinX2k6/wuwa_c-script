using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004228 RID: 16936
	public static class ITrapDefenseConditionStepBase_UnionVerify
	{
		// Token: 0x060190A3 RID: 102563 RVA: 0x0039A4E0 File Offset: 0x003986E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrapDefenseConditionStepBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrapDefenseConditionStepRewardVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrapDefenseConditionStepMapChangeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITrapDefenseConditionStepPreviewVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITrapDefenseConditionStepSpawnMonsterVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITrapDefenseConditionStepLoadAndRestoreMapVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
