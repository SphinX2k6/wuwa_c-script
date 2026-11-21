using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C4 RID: 26820
	public static class IBvbPlayerOperationType_UnionVerify
	{
		// Token: 0x0602DDFA RID: 187898 RVA: 0x00644A1C File Offset: 0x00642C1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBvbPlayerOperationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBvbDeployVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBvbEvolutionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBvbChangeHandCardVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBvbChangeBoardCardVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBvbRecycleHandCardVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBvbRecycleBoardCardVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBvbUseItemCardSkillVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IBvbSelectCardVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IBvbUseFieldCardSkillVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IBvbEndTurnVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
