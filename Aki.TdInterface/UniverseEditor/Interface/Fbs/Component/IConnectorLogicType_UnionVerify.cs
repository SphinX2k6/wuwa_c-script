using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556A RID: 21866
	public static class IConnectorLogicType_UnionVerify
	{
		// Token: 0x06022B7E RID: 142206 RVA: 0x004C82B8 File Offset: 0x004C64B8
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
