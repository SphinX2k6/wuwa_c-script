using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D91 RID: 28049
	public static class IPreloadCharacterType_UnionVerify
	{
		// Token: 0x060318C4 RID: 202948 RVA: 0x006B7390 File Offset: 0x006B5590
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
