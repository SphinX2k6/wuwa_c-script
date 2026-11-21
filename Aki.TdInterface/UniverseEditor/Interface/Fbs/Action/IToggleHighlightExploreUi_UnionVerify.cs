using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BF8 RID: 31736
	public static class IToggleHighlightExploreUi_UnionVerify
	{
		// Token: 0x0603934D RID: 234317 RVA: 0x007BA760 File Offset: 0x007B8960
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IToggleHighlightExploreUiVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowHighlightExploreSkillIconVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHideHighlightExploreSkillIconVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IToggleAndHighlightItemVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
