using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E60 RID: 32352
	public static class TBvbPlayerOperationTypeVerify
	{
		// Token: 0x0603A714 RID: 239380 RVA: 0x007DE528 File Offset: 0x007DC728
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
