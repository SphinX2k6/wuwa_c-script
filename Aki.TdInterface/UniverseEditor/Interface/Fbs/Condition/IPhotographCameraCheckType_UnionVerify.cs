using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C7E RID: 19582
	public static class IPhotographCameraCheckType_UnionVerify
	{
		// Token: 0x0601F0DC RID: 127196 RVA: 0x004571AC File Offset: 0x004553AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPhotographCameraCheckTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPhotographCameraCheckTemplateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPhotographCameraCheckAspectRatioTypeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPhotographCameraCheckBlurIntensityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
