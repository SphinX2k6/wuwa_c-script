using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D99 RID: 32153
	public static class IVisualNovelPerformanceBase_UnionVerify
	{
		// Token: 0x0603A0D1 RID: 237777 RVA: 0x007D334C File Offset: 0x007D154C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelPerformanceBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelPerformanceEnterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelPerformanceExitVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVisualNovelPerformanceMoveVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IVisualNovelPerformanceModifyRoleVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IVisualNovelPerformancePortraitEffectVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IVisualNovelPerformanceBackgroundMoveVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IVisualNovelPerformanceCgMoveVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IVisualNovelPerformanceEnterBlackScreenVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IVisualNovelPerformanceLeaveBlackScreenVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IVisualNovelPerformancePlayScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IVisualNovelPerformanceStopScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IVisualNovelPerformanceSendAudioEventVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IVisualNovelPerformanceSwitchAudioStateVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IVisualNovelPerformanceTransitionVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IVisualNovelPerformanceRoleIntroductionVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IVisualNovelPerformanceActivityActionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
