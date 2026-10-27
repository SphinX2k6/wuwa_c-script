using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B9 RID: 17081
	public static class TBtNodeVerify
	{
		// Token: 0x060194FC RID: 103676 RVA: 0x003A20EC File Offset: 0x003A02EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActionBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActionWithResultBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAlwaysFalseBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAlwaysTrueBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IChildQuestBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IConditionBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IConditionSelectorBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IParallelSelectBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IQuestFailedBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IQuestSucceedBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IRepeaterBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ISelectBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ISequenceBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IStartBtNodeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
