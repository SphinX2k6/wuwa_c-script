using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007658 RID: 30296
	public static class TCameraShakeConfigVerify
	{
		// Token: 0x06037289 RID: 225929 RVA: 0x0077A6E8 File Offset: 0x007788E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILinearOverRangeCameraShakeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IConstantCameraShakeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
