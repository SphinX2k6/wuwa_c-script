using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200621B RID: 25115
	public static class TConnectorLogicVerify
	{
		// Token: 0x0602AC50 RID: 175184 RVA: 0x005D79E8 File Offset: 0x005D5BE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IConnectorRangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IConnectorPointToPointPathAdvanceVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
