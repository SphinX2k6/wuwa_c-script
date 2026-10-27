using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AC RID: 30380
	public static class TDynamicSettlementConfigVerify
	{
		// Token: 0x06037451 RID: 226385 RVA: 0x0077D5C4 File Offset: 0x0077B7C4
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
