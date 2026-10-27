using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007369 RID: 29545
	public static class ITargetVehicle_UnionVerify
	{
		// Token: 0x060359FF RID: 219647 RVA: 0x0074D67C File Offset: 0x0074B87C
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
