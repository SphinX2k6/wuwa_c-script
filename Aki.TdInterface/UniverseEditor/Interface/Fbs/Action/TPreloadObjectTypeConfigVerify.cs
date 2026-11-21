using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F8D RID: 32653
	public static class TPreloadObjectTypeConfigVerify
	{
		// Token: 0x0603AD80 RID: 241024 RVA: 0x007E875C File Offset: 0x007E695C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPreloadFlowsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPreloadLinkResourceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPreloadMp4sVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPreloadPhantomCharacterForSkillVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPreloadTrialCharacterForSkillVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
