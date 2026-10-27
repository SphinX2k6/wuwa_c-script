using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757F RID: 30079
	public static class IVisualNovelDisplayItemBase_UnionVerify
	{
		// Token: 0x06036B85 RID: 224133 RVA: 0x0076DF08 File Offset: 0x0076C108
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
