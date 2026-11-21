using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200473F RID: 18239
	public static class TLeafBtNodeVerify
	{
		// Token: 0x0601ADD8 RID: 110040 RVA: 0x003D00B4 File Offset: 0x003CE2B4
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
				result = IChildQuestBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IConditionBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IQuestFailedBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IQuestSucceedBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IStartBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IAlwaysTrueBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IAlwaysFalseBtNodeVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IRepeaterBtNodeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
