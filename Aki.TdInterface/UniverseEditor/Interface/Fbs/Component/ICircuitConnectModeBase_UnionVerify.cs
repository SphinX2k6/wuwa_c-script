using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EC RID: 21740
	public static class ICircuitConnectModeBase_UnionVerify
	{
		// Token: 0x0602253A RID: 140602 RVA: 0x004BB4AC File Offset: 0x004B96AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICircuitConnectModeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICircuitConnectTwoRingsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICircuitConnectThreeRingsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
