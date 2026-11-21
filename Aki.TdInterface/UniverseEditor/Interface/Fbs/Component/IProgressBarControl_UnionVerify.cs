using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DAB RID: 23979
	public static class IProgressBarControl_UnionVerify
	{
		// Token: 0x06027F5F RID: 163679 RVA: 0x0057751C File Offset: 0x0057571C
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
