using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D60 RID: 32096
	public static class IVisualNovelCgBase_UnionVerify
	{
		// Token: 0x06039EF9 RID: 237305 RVA: 0x007D01A0 File Offset: 0x007CE3A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelCgBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelCgLoadPrefabVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelCgLoadImageVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVisualNovelCgCleanVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
