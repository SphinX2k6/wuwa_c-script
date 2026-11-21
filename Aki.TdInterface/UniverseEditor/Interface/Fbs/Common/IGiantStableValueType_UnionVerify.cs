using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200641E RID: 25630
	public static class IGiantStableValueType_UnionVerify
	{
		// Token: 0x0602B8B5 RID: 178357 RVA: 0x005EDF6C File Offset: 0x005EC16C
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
