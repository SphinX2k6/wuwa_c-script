using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004273 RID: 17011
	public static class IVisionSystemQuestBase_UnionVerify
	{
		// Token: 0x060192D4 RID: 103124 RVA: 0x0039E208 File Offset: 0x0039C408
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
