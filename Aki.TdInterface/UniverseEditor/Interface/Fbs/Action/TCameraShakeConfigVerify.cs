using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E66 RID: 32358
	public static class TCameraShakeConfigVerify
	{
		// Token: 0x0603A72E RID: 239406 RVA: 0x007DE7E4 File Offset: 0x007DC9E4
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
