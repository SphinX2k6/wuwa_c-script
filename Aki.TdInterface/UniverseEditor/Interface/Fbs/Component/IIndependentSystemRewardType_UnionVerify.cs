using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F7 RID: 21495
	public static class IIndependentSystemRewardType_UnionVerify
	{
		// Token: 0x060234C6 RID: 144582 RVA: 0x004E303C File Offset: 0x004E123C
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
