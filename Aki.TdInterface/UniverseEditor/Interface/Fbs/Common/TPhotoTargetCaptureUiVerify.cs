using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064D5 RID: 25813
	public static class TPhotoTargetCaptureUiVerify
	{
		// Token: 0x0602BE05 RID: 179717 RVA: 0x005F742C File Offset: 0x005F562C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPhotoTargetCaptureUiCustomPointsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPhotoTargetCaptureUiEachRequiredPointsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPhotoTargetCaptureUiEntityZeroVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPhotoTargetCaptureUiRequiredPointsCenterVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
