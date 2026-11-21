using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D75 RID: 32117
	public static class IVisualNovelDisplayItemBase_UnionVerify
	{
		// Token: 0x06039FAD RID: 237485 RVA: 0x007D14AC File Offset: 0x007CF6AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelDisplayItemBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelDisplayItemImageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelDisplayItemPrefabVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVisualNovelDisplayItemCloseVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
