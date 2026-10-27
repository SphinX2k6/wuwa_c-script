using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004386 RID: 17286
	public static class TPerformerAiNodeVerify
	{
		// Token: 0x06019B72 RID: 105330 RVA: 0x003AED5C File Offset: 0x003ACF5C
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
