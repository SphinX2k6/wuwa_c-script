using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D6C RID: 19820
	public static class ICircuitConnectAssetBase_UnionVerify
	{
		// Token: 0x0601EB76 RID: 125814 RVA: 0x0044BDE0 File Offset: 0x00449FE0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICircuitConnectAssetBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICircuitConnectStraightAssetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICircuitConnectCurveAssetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICircuitConnectPowerPortAssetVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICircuitConnectOutputPortAssetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
