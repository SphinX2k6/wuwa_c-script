using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200800B RID: 32779
	public static class TTargetVehicleVerify
	{
		// Token: 0x0603AFD8 RID: 241624 RVA: 0x007EBDFC File Offset: 0x007E9FFC
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
