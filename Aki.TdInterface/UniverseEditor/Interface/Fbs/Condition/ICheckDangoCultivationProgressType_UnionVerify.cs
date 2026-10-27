using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049C0 RID: 18880
	public static class ICheckDangoCultivationProgressType_UnionVerify
	{
		// Token: 0x0601D79B RID: 120731 RVA: 0x00426E24 File Offset: 0x00425024
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
