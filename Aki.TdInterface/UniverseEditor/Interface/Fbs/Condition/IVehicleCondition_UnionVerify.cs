using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200520D RID: 21005
	public static class IVehicleCondition_UnionVerify
	{
		// Token: 0x0602114C RID: 135500 RVA: 0x00491F1C File Offset: 0x0049011C
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
