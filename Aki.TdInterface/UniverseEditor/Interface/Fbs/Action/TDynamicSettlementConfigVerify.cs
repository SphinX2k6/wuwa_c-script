using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EB7 RID: 32439
	public static class TDynamicSettlementConfigVerify
	{
		// Token: 0x0603A8F4 RID: 239860 RVA: 0x007E1718 File Offset: 0x007DF918
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISoaringChallengeSettlementVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBattleSettlementVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
