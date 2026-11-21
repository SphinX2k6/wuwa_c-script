using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004742 RID: 18242
	public static class TLogicBtNodeVerify
	{
		// Token: 0x0601ADE8 RID: 110056 RVA: 0x003D0294 File Offset: 0x003CE494
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
