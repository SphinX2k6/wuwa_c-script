using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200646F RID: 25711
	public static class IPhotoTargetCaptureUiBase_UnionVerify
	{
		// Token: 0x0602BB07 RID: 178951 RVA: 0x005F2034 File Offset: 0x005F0234
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPhotoTargetCaptureUiBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPhotoTargetCaptureUiRequiredPointsCenterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPhotoTargetCaptureUiEntityZeroVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPhotoTargetCaptureUiEachRequiredPointsVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPhotoTargetCaptureUiCustomPointsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
