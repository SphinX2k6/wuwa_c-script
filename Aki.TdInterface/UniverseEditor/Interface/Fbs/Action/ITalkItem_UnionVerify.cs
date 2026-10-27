using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731E RID: 29470
	public static class ITalkItem_UnionVerify
	{
		// Token: 0x0603577A RID: 219002 RVA: 0x00748948 File Offset: 0x00746B48
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkItemVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkItemDialogVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkItemOptionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkItemSystemOptionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITalkItemCenterTextVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITalkItemQteVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ITalkItemNoTextItemVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ITalkItemPhoneMessageVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ITalkItemAvgTalkVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ITalkItemAvgEnterVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ITalkItemAvgExitVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = ITalkItemAvgOptionVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ITalkItemAvgNarrationVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ITalkItemAvgCenterTextVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ITalkItemVisualNovelTalkVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = ITalkItemVisualNovelNoTextItemVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ITalkItemVisualNovelNarrationVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = ITalkItemVisualNovelOptionVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = ITalkItemVisualNovelCenterTextVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
