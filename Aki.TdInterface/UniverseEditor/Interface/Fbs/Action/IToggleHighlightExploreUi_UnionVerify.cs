using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200740E RID: 29710
	public static class IToggleHighlightExploreUi_UnionVerify
	{
		// Token: 0x06035F9A RID: 221082 RVA: 0x00757FEC File Offset: 0x007561EC
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
