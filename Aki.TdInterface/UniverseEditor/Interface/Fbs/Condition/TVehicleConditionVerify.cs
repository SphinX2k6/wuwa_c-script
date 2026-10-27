using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D5F RID: 19807
	public static class TVehicleConditionVerify
	{
		// Token: 0x0601F6CD RID: 128717 RVA: 0x00460B84 File Offset: 0x0045ED84
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckIsPlayerUsingVehicleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckIsUsingVehicleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckVehicleSpeedConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICheckVehicleTriggerAngleConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
