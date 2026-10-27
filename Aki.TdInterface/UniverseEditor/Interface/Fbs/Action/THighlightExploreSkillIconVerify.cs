using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F1 RID: 30449
	public static class THighlightExploreSkillIconVerify
	{
		// Token: 0x060375AB RID: 226731 RVA: 0x0077F600 File Offset: 0x0077D800
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHideHighlightExploreSkillIconVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowHighlightExploreSkillIconVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
