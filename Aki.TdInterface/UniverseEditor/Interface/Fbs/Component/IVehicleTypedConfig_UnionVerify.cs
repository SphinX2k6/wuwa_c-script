using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2E RID: 23342
	public static class IVehicleTypedConfig_UnionVerify
	{
		// Token: 0x06027E49 RID: 163401 RVA: 0x0057C580 File Offset: 0x0057A780
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVehicleTypedMotorConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVehicleTypedConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
