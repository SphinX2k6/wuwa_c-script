using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D3F RID: 15679
	public static class IBtNode_UnionVerify
	{
		// Token: 0x06015AAC RID: 88748 RVA: 0x00320550 File Offset: 0x0031E750
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
