using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D3 RID: 30675
	public static class TTargetVehicleVerify
	{
		// Token: 0x06037A53 RID: 227923 RVA: 0x00786798 File Offset: 0x00784998
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAppointedVehicleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICurrentVehicleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFishingBoatVehicleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISelfVehicleVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITriggeredVehicleVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IVehiclePlayerMotorVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IVehicleTeamVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
