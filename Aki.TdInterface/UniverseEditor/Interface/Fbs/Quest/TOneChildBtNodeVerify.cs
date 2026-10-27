using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EC RID: 17132
	public static class TOneChildBtNodeVerify
	{
		// Token: 0x060196A0 RID: 104096 RVA: 0x003A4EFC File Offset: 0x003A30FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAlwaysFalseBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAlwaysTrueBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRepeaterBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IStartBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IQuestSucceedBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IQuestFailedBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IConditionBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IChildQuestBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IActionBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 10:
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
