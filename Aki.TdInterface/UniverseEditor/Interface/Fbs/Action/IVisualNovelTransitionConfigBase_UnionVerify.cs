using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DF3 RID: 32243
	public static class IVisualNovelTransitionConfigBase_UnionVerify
	{
		// Token: 0x0603A442 RID: 238658 RVA: 0x007D9D94 File Offset: 0x007D7F94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelTransitionConfigBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelTransitionLocationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelTransitionTimeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
