using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064C9 RID: 25801
	public static class TGiantStableValueVerify
	{
		// Token: 0x0602BDCB RID: 179659 RVA: 0x005F6EF4 File Offset: 0x005F50F4
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
