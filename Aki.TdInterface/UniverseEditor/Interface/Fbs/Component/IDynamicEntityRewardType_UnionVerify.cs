using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005648 RID: 22088
	public static class IDynamicEntityRewardType_UnionVerify
	{
		// Token: 0x060234A6 RID: 144550 RVA: 0x004DB020 File Offset: 0x004D9220
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
