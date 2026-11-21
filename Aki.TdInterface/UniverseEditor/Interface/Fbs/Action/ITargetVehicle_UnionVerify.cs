using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B44 RID: 31556
	public static class ITargetVehicle_UnionVerify
	{
		// Token: 0x06038D48 RID: 232776 RVA: 0x007AF450 File Offset: 0x007AD650
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITargetVehicleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICurrentVehicleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISelfVehicleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAppointedVehicleVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITriggeredVehicleVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFishingBoatVehicleVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IVehicleTeamVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IVehiclePlayerMotorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
