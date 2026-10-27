using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DE1 RID: 24033
	public static class IGiantStableValueType_UnionVerify
	{
		// Token: 0x0602922B RID: 168491 RVA: 0x005A523C File Offset: 0x005A343C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGiantStableValueTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGiantStableValueRegionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGiantStableValueTotalVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
