using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C74 RID: 23668
	public static class TNpcRideInVehiclePerformTypeVerify
	{
		// Token: 0x060288D8 RID: 166104 RVA: 0x005937BC File Offset: 0x005919BC
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
