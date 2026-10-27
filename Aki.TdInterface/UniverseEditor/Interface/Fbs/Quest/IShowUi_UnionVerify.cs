using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004132 RID: 16690
	public static class IShowUi_UnionVerify
	{
		// Token: 0x060187AB RID: 100267 RVA: 0x003877E4 File Offset: 0x003859E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IShowUiVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowUiAllVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRogueAbilitySelectVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IInformationViewVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRogueRandomEventVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRoleTrialActivitiesVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRoleSkinTrialActivitiesVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IMowBuffDistributeVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IPermanentRogueUiVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = ICiacconaAvgBoardVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IItemObtainVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IShowUiCraftingVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IShowUiCookVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IShowUiSyntheticVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IShowUiForgingVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
