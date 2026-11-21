using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006129 RID: 24873
	public static class IVehicleFeature_UnionVerify
	{
		// Token: 0x0602A321 RID: 172833 RVA: 0x005C243C File Offset: 0x005C063C
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
