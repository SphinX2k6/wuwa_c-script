using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780F RID: 30735
	public static class TVisualNovelCgVerify
	{
		// Token: 0x06037BAD RID: 228269 RVA: 0x007889D4 File Offset: 0x00786BD4
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
				result = IVisualNovelCgLoadSpineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
