using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004156 RID: 16726
	public static class IBtNode_UnionVerify
	{
		// Token: 0x06016FE4 RID: 94180 RVA: 0x003477C8 File Offset: 0x003459C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IStartBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestSucceedBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IQuestFailedBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IAlwaysTrueBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IAlwaysFalseBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRepeaterBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ILogicBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ISequenceBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ISelectBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IParallelSelectBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IConditionSelectorBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IConditionBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IChildQuestBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IActionBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IActionWithResultBtNodeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
