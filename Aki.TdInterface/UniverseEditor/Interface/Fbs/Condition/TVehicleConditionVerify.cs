using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200525B RID: 21083
	public static class TVehicleConditionVerify
	{
		// Token: 0x06021316 RID: 135958 RVA: 0x00494B58 File Offset: 0x00492D58
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
