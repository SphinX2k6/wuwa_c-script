using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C92 RID: 23698
	public static class TProgressBarControlVerify
	{
		// Token: 0x06028974 RID: 166260 RVA: 0x0059465C File Offset: 0x0059285C
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
