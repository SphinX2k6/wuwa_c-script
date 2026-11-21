using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBD RID: 28093
	public static class IExitVehicleType_UnionVerify
	{
		// Token: 0x060307D4 RID: 198612 RVA: 0x00696080 File Offset: 0x00694280
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExitVehicleTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IExitVehicleLaunchVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IExitVehicleStandUpVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IExitVehicleTeleportVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IExitVehicleSeatStandUpVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
