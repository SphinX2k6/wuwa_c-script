using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E3 RID: 20707
	public static class IDynamicEntityRewardType_UnionVerify
	{
		// Token: 0x06021552 RID: 136530 RVA: 0x004A1094 File Offset: 0x0049F294
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDynamicTrafficRewardVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDynamicEntityRewardTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
