using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D11 RID: 19729
	public static class IVehicleCondition_UnionVerify
	{
		// Token: 0x0601F507 RID: 128263 RVA: 0x0045DFCC File Offset: 0x0045C1CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVehicleConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckIsUsingVehicleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckIsPlayerUsingVehicleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICheckVehicleSpeedConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
