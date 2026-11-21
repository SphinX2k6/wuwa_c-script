using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E7A RID: 20090
	public static class ICheckDangoCultivationProgressType_UnionVerify
	{
		// Token: 0x0601F1DA RID: 127450 RVA: 0x0045756C File Offset: 0x0045576C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICountDangoOverTargetLevelVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckDangoCultivationProgressTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
