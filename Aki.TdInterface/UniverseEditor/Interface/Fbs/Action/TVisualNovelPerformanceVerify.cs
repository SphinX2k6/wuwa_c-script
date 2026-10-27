using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007815 RID: 30741
	public static class TVisualNovelPerformanceVerify
	{
		// Token: 0x06037BE5 RID: 228325 RVA: 0x00788F3C File Offset: 0x0078713C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelPerformanceActivityActionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelPerformanceBackgroundMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelPerformanceCgMoveVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVisualNovelPerformanceEnterVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IVisualNovelPerformanceEnterBlackScreenVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IVisualNovelPerformanceExitVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IVisualNovelPerformanceLeaveBlackScreenVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IVisualNovelPerformanceModifyRoleVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IVisualNovelPerformanceMoveVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IVisualNovelPerformancePlayScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IVisualNovelPerformancePortraitEffectVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IVisualNovelPerformanceRoleIntroductionVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IVisualNovelPerformanceSendAudioEventVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IVisualNovelPerformanceStopScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IVisualNovelPerformanceSwitchAudioStateVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IVisualNovelPerformanceTransitionVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IVisualNovelPerformanceUiShakeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
