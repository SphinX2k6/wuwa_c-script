using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597D RID: 22909
	public static class IIndependentSystemRewardType_UnionVerify
	{
		// Token: 0x0602557E RID: 152958 RVA: 0x00520068 File Offset: 0x0051E268
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDarkTideIndependentSystemRewardVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IIndependentSystemRewardTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
