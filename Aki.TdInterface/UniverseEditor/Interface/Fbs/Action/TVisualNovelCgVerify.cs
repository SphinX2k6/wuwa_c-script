using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200804D RID: 32845
	public static class TVisualNovelCgVerify
	{
		// Token: 0x0603B152 RID: 242002 RVA: 0x007EE34C File Offset: 0x007EC54C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelCgCleanVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelCgLoadImageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelCgLoadPrefabVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
