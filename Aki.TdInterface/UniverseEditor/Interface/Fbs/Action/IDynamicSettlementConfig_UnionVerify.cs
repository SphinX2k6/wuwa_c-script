using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C94 RID: 27796
	public static class IDynamicSettlementConfig_UnionVerify
	{
		// Token: 0x0602FE47 RID: 196167 RVA: 0x0068539C File Offset: 0x0068359C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDynamicSettlementConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBattleSettlementVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISoaringChallengeSettlementVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
