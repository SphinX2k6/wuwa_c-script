using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005177 RID: 20855
	public static class IPhotographCameraCheckType_UnionVerify
	{
		// Token: 0x06020CFE RID: 134398 RVA: 0x0048ACFC File Offset: 0x00488EFC
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
