using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D50 RID: 19792
	public static class TPhotographCameraCheckTypeVerify
	{
		// Token: 0x0601F687 RID: 128647 RVA: 0x00460538 File Offset: 0x0045E738
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPhotographCameraCheckAspectRatioTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPhotographCameraCheckBlurIntensityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPhotographCameraCheckTemplateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
