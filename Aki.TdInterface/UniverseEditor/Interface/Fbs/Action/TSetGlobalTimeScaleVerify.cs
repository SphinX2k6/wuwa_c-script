using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FBA RID: 32698
	public static class TSetGlobalTimeScaleVerify
	{
		// Token: 0x0603AE42 RID: 241218 RVA: 0x007E9850 File Offset: 0x007E7A50
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOpenGlobalTimeScaleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICloseGlobalTimeScaleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
