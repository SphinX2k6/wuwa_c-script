using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673D RID: 26429
	public static class IExitVehicleType_UnionVerify
	{
		// Token: 0x0602DF8E RID: 188302 RVA: 0x0064893C File Offset: 0x00646B3C
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
