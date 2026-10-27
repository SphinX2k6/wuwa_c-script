using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007652 RID: 30290
	public static class TBvbPlayerOperationTypeVerify
	{
		// Token: 0x0603726F RID: 225903 RVA: 0x0077A42C File Offset: 0x0077862C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBvbChangeBoardCardVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBvbChangeHandCardVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBvbDeployVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBvbEndTurnVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBvbEvolutionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBvbRecycleBoardCardVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBvbRecycleHandCardVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBvbSelectCardVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IBvbUseFieldCardSkillVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IBvbUseItemCardSkillVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
