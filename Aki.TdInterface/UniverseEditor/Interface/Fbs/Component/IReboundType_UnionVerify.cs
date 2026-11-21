using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E1A RID: 24090
	public static class IReboundType_UnionVerify
	{
		// Token: 0x060283A2 RID: 164770 RVA: 0x005803D0 File Offset: 0x0057E5D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IForwardFrontReboundVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IReboundTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
