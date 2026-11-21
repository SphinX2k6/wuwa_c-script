using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006302 RID: 25346
	public static class TTurntableControllerVerify
	{
		// Token: 0x0602B0E6 RID: 176358 RVA: 0x005DE900 File Offset: 0x005DCB00
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
