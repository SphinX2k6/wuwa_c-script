using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006918 RID: 26904
	public static class ICameraShakeConfig_UnionVerify
	{
		// Token: 0x0602E18F RID: 188815 RVA: 0x0064C91C File Offset: 0x0064AB1C
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
