using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E3 RID: 17123
	public static class TLogicBtNodeVerify
	{
		// Token: 0x06019666 RID: 104038 RVA: 0x003A4964 File Offset: 0x003A2B64
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IConditionSelectorBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IParallelSelectBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISelectBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISequenceBtNodeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
