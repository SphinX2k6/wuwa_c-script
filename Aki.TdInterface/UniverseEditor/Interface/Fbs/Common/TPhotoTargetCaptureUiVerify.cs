using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E92 RID: 24210
	public static class TPhotoTargetCaptureUiVerify
	{
		// Token: 0x0602975D RID: 169821 RVA: 0x005AE488 File Offset: 0x005AC688
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
