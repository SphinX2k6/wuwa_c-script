using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200620F RID: 25103
	public static class TCircuitConnectLayoutTypeVerify
	{
		// Token: 0x0602AB3C RID: 174908 RVA: 0x005D2530 File Offset: 0x005D0730
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICircuitConnectCurveLayoutVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICircuitConnectOutputPortLayoutVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICircuitConnectPowerPortLayoutVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICircuitConnectStraightLayoutVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
