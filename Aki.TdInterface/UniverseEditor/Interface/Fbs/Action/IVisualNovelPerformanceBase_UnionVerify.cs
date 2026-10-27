using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A0 RID: 30112
	public static class IVisualNovelPerformanceBase_UnionVerify
	{
		// Token: 0x06036CA3 RID: 224419 RVA: 0x0076FDBC File Offset: 0x0076DFBC
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
				result = IVisualNovelPerformanceUiShakeVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IVisualNovelPerformanceBackgroundMoveVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IVisualNovelPerformanceCgMoveVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IVisualNovelPerformanceEnterBlackScreenVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IVisualNovelPerformanceLeaveBlackScreenVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IVisualNovelPerformancePlayScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IVisualNovelPerformanceStopScreenEffectVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IVisualNovelPerformanceSendAudioEventVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IVisualNovelPerformanceSwitchAudioStateVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IVisualNovelPerformanceTransitionVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IVisualNovelPerformanceRoleIntroductionVerify.Verify(verifier, tablePos);
				break;
			case 18:
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
