using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E82 RID: 24194
	public static class IRoadNetworkNavigationType_UnionVerify
	{
		// Token: 0x060287E7 RID: 165863 RVA: 0x00589944 File Offset: 0x00587B44
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
