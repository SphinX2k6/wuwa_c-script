using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007761 RID: 30561
	public static class TPreloadObjectTypeConfigVerify
	{
		// Token: 0x06037837 RID: 227383 RVA: 0x0078368C File Offset: 0x0078188C
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
