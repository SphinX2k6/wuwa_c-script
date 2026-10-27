using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756A RID: 30058
	public static class IVisualNovelCgBase_UnionVerify
	{
		// Token: 0x06036AE3 RID: 223971 RVA: 0x0076CEF8 File Offset: 0x0076B0F8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelCgBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelCgLoadSpineVerify.Verify(verifier, tablePos);
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
