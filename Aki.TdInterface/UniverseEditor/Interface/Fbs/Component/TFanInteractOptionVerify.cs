using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200623F RID: 25151
	public static class TFanInteractOptionVerify
	{
		// Token: 0x0602AD1E RID: 175390 RVA: 0x005D8F68 File Offset: 0x005D7168
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
