using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E0 RID: 21728
	public static class ICircuitConnectLayoutBase_UnionVerify
	{
		// Token: 0x060224CA RID: 140490 RVA: 0x004BA5A0 File Offset: 0x004B87A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICircuitConnectLayoutBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICircuitConnectStraightLayoutVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICircuitConnectCurveLayoutVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICircuitConnectPowerPortLayoutVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICircuitConnectOutputPortLayoutVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
