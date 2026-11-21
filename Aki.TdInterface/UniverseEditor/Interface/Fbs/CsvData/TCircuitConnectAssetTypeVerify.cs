using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC6 RID: 19910
	public static class TCircuitConnectAssetTypeVerify
	{
		// Token: 0x0601EE48 RID: 126536 RVA: 0x00450E14 File Offset: 0x0044F014
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICircuitConnectCurveAssetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICircuitConnectOutputPortAssetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICircuitConnectPowerPortAssetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICircuitConnectStraightAssetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
