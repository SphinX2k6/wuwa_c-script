using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046CF RID: 18127
	public static class IVisionSystemQuestBase_UnionVerify
	{
		// Token: 0x0601AA40 RID: 109120 RVA: 0x003C98E0 File Offset: 0x003C7AE0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisionSystemQuestBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisionSystemQuestTargetLevelVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisionSystemQuestSetActivatedVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVisionSystemQuestDoIdentifyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
