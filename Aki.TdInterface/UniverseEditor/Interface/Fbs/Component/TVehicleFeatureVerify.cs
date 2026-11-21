using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006305 RID: 25349
	public static class TVehicleFeatureVerify
	{
		// Token: 0x0602B0FA RID: 176378 RVA: 0x005DEAD0 File Offset: 0x005DCCD0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAudioVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBattleVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMovablePlatformVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMovementVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPerformanceVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISharingVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
