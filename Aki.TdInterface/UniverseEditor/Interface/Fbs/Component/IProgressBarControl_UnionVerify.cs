using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A4 RID: 22436
	public static class IProgressBarControl_UnionVerify
	{
		// Token: 0x06025A3F RID: 154175 RVA: 0x00531390 File Offset: 0x0052F590
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IProgressBarControlVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICaptureStrategicPointVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICaptureStrategicPoint2Verify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IChargingDeviceVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITimedStrikeDeviceVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IMatchTargetChargingDeviceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
