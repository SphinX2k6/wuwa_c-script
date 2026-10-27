using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD1 RID: 23761
	public static class TVehicleFeatureVerify
	{
		// Token: 0x06028AA6 RID: 166566 RVA: 0x00596260 File Offset: 0x00594460
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
