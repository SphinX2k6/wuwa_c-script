using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BEA RID: 23530
	public static class INpcRideInVehiclePerformType_UnionVerify
	{
		// Token: 0x06026DC3 RID: 159171 RVA: 0x0055205C File Offset: 0x0055025C
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
