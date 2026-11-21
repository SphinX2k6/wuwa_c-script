using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200524C RID: 21068
	public static class TPhotographCameraCheckTypeVerify
	{
		// Token: 0x060212D0 RID: 135888 RVA: 0x0049450C File Offset: 0x0049270C
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
