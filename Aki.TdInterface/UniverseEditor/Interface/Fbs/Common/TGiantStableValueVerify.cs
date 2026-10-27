using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E86 RID: 24198
	public static class TGiantStableValueVerify
	{
		// Token: 0x06029723 RID: 169763 RVA: 0x005ADF50 File Offset: 0x005AC150
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IGiantStableValueTotalVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGiantStableValueRegionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
