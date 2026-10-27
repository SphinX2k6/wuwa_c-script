using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E6 RID: 17126
	public static class TManyChildrenBtNodeVerify
	{
		// Token: 0x06019676 RID: 104054 RVA: 0x003A4AF0 File Offset: 0x003A2CF0
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
