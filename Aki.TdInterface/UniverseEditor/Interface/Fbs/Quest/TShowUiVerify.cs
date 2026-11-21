using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004775 RID: 18293
	public static class TShowUiVerify
	{
		// Token: 0x0601AF10 RID: 110352 RVA: 0x003D1F0C File Offset: 0x003D010C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICiacconaAvgBoardVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInformationViewVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IItemObtainVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMowBuffDistributeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPermanentRogueUiVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRogueAbilitySelectVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRogueRandomEventVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IRoleSkinTrialActivitiesVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IRoleTrialActivitiesVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IShowUiAllVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IShowUiCookVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IShowUiForgingVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IShowUiSyntheticVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
