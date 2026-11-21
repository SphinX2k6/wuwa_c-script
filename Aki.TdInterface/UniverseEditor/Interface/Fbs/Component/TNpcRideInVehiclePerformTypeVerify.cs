using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200629C RID: 25244
	public static class TNpcRideInVehiclePerformTypeVerify
	{
		// Token: 0x0602AEF8 RID: 175864 RVA: 0x005DBBB0 File Offset: 0x005D9DB0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICyberpunkShareEmptyVehiclePerformVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcRideInAutoGongduolaPerformVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcRideInGongduolaPerformVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IWoodenOxenAndFlowingHorsesPerformVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
