using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004371 RID: 17265
	public static class IPerformerAiNodeBase_UnionVerify
	{
		// Token: 0x060199DF RID: 104927 RVA: 0x003AA784 File Offset: 0x003A8984
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
