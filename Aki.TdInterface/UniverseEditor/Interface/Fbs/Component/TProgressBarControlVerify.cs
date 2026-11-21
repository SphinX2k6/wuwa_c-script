using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062C3 RID: 25283
	public static class TProgressBarControlVerify
	{
		// Token: 0x0602AFBA RID: 176058 RVA: 0x005DCD94 File Offset: 0x005DAF94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICaptureStrategicPointVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICaptureStrategicPoint2Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IChargingDeviceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMatchTargetChargingDeviceVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITimedStrikeDeviceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
