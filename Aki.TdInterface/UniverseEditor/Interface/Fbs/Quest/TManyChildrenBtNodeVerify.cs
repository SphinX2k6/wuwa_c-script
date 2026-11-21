using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004745 RID: 18245
	public static class TManyChildrenBtNodeVerify
	{
		// Token: 0x0601ADF8 RID: 110072 RVA: 0x003D0420 File Offset: 0x003CE620
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IParallelSelectBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISelectBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISequenceBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IConditionSelectorBtNodeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
