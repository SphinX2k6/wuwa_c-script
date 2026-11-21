using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D87 RID: 32135
	public static class IVisualNovelOptionGroupConfigBase_UnionVerify
	{
		// Token: 0x0603A01D RID: 237597 RVA: 0x007D1E6C File Offset: 0x007D006C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelOptionGroupConfigBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelOptionGroupNormalVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelOptionGroupFullScreenVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
