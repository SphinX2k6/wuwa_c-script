using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200637B RID: 25467
	public static class IClaimDynamicEntityRewardType_UnionVerify
	{
		// Token: 0x0602C0D3 RID: 180435 RVA: 0x0060D378 File Offset: 0x0060B578
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClaimDynamicTrafficRewardVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClaimDynamicEntityRewardTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
