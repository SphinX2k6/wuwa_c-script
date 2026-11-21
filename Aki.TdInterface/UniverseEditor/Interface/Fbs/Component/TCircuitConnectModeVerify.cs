using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006212 RID: 25106
	public static class TCircuitConnectModeVerify
	{
		// Token: 0x0602AB48 RID: 174920 RVA: 0x005D2650 File Offset: 0x005D0850
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICircuitConnectTwoRingsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICircuitConnectThreeRingsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
