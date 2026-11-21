using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008050 RID: 32848
	public static class TVisualNovelDisplayItemVerify
	{
		// Token: 0x0603B160 RID: 242016 RVA: 0x007EE498 File Offset: 0x007EC698
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelDisplayItemCloseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelDisplayItemImageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelDisplayItemPrefabVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
