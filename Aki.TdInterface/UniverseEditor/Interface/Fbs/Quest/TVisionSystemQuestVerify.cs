using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004337 RID: 17207
	public static class TVisionSystemQuestVerify
	{
		// Token: 0x0601983A RID: 104506 RVA: 0x003A76C0 File Offset: 0x003A58C0
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
