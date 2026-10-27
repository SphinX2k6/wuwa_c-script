using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200500B RID: 20491
	public static class IConnectorLogicType_UnionVerify
	{
		// Token: 0x06020C5E RID: 134238 RVA: 0x0048E868 File Offset: 0x0048CA68
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IConnectorLogicTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IConnectorRangeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IConnectorPointToPointPathAdvanceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
