using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564C RID: 22092
	public static class INpcRideInVehiclePerformType_UnionVerify
	{
		// Token: 0x06024BA4 RID: 150436 RVA: 0x00511738 File Offset: 0x0050F938
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcRideInVehiclePerformTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcRideInGongduolaPerformVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcRideInAutoGongduolaPerformVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICyberpunkShareEmptyVehiclePerformVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
