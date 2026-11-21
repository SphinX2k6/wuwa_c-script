using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047E8 RID: 18408
	public static class TPerformerAiNodeVerify
	{
		// Token: 0x0601B300 RID: 111360 RVA: 0x003DA784 File Offset: 0x003D8984
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPerformerAiProbabilityVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPerformerAiSelectorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerformerAiSequenceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPerformerAiStartVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPerformerAiTaskVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
