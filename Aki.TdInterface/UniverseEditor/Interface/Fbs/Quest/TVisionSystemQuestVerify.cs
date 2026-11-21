using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004799 RID: 18329
	public static class TVisionSystemQuestVerify
	{
		// Token: 0x0601AFC8 RID: 110536 RVA: 0x003D30E8 File Offset: 0x003D12E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisionSystemQuestDoIdentifyVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisionSystemQuestSetActivatedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisionSystemQuestTargetLevelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
