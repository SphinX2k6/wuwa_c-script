using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFC RID: 23548
	public static class TConnectorLogicVerify
	{
		// Token: 0x06028660 RID: 165472 RVA: 0x0058FAA0 File Offset: 0x0058DCA0
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
