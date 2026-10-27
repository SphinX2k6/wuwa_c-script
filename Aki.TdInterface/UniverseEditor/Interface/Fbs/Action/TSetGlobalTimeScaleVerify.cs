using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007782 RID: 30594
	public static class TSetGlobalTimeScaleVerify
	{
		// Token: 0x060378C9 RID: 227529 RVA: 0x00784390 File Offset: 0x00782590
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
