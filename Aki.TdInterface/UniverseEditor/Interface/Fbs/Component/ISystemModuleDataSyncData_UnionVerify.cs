using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A21 RID: 23073
	public static class ISystemModuleDataSyncData_UnionVerify
	{
		// Token: 0x060272F8 RID: 160504 RVA: 0x00563DD4 File Offset: 0x00561FD4
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
