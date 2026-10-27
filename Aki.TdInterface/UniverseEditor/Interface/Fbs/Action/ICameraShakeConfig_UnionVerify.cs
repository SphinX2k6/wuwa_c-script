using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A7 RID: 25255
	public static class ICameraShakeConfig_UnionVerify
	{
		// Token: 0x0602BA2E RID: 178734 RVA: 0x00601B14 File Offset: 0x005FFD14
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICameraShakeConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IConstantCameraShakeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILinearOverRangeCameraShakeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
