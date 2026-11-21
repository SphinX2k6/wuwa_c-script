using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006144 RID: 24900
	public static class IVehicleTypedConfig_UnionVerify
	{
		// Token: 0x0602A40D RID: 173069 RVA: 0x005C3FD4 File Offset: 0x005C21D4
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
