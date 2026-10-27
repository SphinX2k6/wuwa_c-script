using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C4 RID: 30404
	public static class TExitVehicleTypeVerify
	{
		// Token: 0x060374D5 RID: 226517 RVA: 0x0077E264 File Offset: 0x0077C464
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExitVehicleLaunchVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IExitVehicleSeatStandUpVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IExitVehicleStandUpVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IExitVehicleTeleportVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
