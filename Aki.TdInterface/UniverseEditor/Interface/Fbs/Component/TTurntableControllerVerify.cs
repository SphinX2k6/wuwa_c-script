using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCE RID: 23758
	public static class TTurntableControllerVerify
	{
		// Token: 0x06028A92 RID: 166546 RVA: 0x00596090 File Offset: 0x00594290
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFreeAngleTurntableVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFixedAngleTurntableVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
