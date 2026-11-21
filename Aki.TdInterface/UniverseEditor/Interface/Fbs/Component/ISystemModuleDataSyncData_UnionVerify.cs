using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200602E RID: 24622
	public static class ISystemModuleDataSyncData_UnionVerify
	{
		// Token: 0x06029870 RID: 170096 RVA: 0x005AAD98 File Offset: 0x005A8F98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISystemModuleDataSyncMotorRacingVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISystemModuleDataSyncDataVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
