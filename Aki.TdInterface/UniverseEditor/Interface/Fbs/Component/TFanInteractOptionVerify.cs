using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C20 RID: 23584
	public static class TFanInteractOptionVerify
	{
		// Token: 0x0602872C RID: 165676 RVA: 0x00590FD8 File Offset: 0x0058F1D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFanInteractByHitVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFanInteractByFKeyVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
