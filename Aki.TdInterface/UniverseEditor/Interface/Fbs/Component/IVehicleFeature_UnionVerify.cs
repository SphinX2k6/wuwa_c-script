using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B13 RID: 23315
	public static class IVehicleFeature_UnionVerify
	{
		// Token: 0x06027D5D RID: 163165 RVA: 0x0057A9E8 File Offset: 0x00578BE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMovementVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBattleVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAudioVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IMovablePlatformVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ISharingVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IPerformanceVehicleFeatureVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
