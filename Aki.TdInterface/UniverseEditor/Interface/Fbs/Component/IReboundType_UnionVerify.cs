using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005813 RID: 22547
	public static class IReboundType_UnionVerify
	{
		// Token: 0x06025E82 RID: 155266 RVA: 0x0053A244 File Offset: 0x00538444
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
