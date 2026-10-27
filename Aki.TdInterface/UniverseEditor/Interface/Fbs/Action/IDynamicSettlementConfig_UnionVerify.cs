using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006623 RID: 26147
	public static class IDynamicSettlementConfig_UnionVerify
	{
		// Token: 0x0602D676 RID: 185974 RVA: 0x00638834 File Offset: 0x00636A34
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
