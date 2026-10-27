using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C23 RID: 23587
	public static class TFillConfigVerify
	{
		// Token: 0x06028738 RID: 165688 RVA: 0x005910D4 File Offset: 0x0058F2D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFixedFillVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDirectionFillVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
