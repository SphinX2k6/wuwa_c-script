using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200750C RID: 29964
	public static class IPreloadCharacterType_UnionVerify
	{
		// Token: 0x060348C0 RID: 215232 RVA: 0x00712A78 File Offset: 0x00710C78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPreloadCharacterTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPreloadTrialCharacterForSkillVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPreloadPhantomCharacterForSkillVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPreloadMp4sVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPreloadFlowsVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPreloadLinkResourceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
