using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047D3 RID: 18387
	public static class IPerformerAiNodeBase_UnionVerify
	{
		// Token: 0x0601B16D RID: 110957 RVA: 0x003D61AC File Offset: 0x003D43AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPerformerAiNodeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPerformerAiStartVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerformerAiSequenceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPerformerAiSelectorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPerformerAiTaskVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPerformerAiProbabilityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
