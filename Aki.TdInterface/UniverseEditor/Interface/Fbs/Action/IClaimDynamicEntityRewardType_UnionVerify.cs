using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069EC RID: 27116
	public static class IClaimDynamicEntityRewardType_UnionVerify
	{
		// Token: 0x0602E83D RID: 190525 RVA: 0x006584CC File Offset: 0x006566CC
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
