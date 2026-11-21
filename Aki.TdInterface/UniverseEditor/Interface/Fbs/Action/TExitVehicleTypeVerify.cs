using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ED2 RID: 32466
	public static class TExitVehicleTypeVerify
	{
		// Token: 0x0603A98A RID: 240010 RVA: 0x007E2578 File Offset: 0x007E0778
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
