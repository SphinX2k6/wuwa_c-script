using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005875 RID: 22645
	public static class IRoadNetworkNavigationType_UnionVerify
	{
		// Token: 0x06026285 RID: 156293 RVA: 0x00542DF8 File Offset: 0x00540FF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITrafficNavigationConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRoadNetworkNavigationTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
