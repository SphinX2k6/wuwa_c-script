using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D54 RID: 32084
	public static class IVisualNovelBackgroundBase_UnionVerify
	{
		// Token: 0x06039EAF RID: 237231 RVA: 0x007CFB34 File Offset: 0x007CDD34
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelBackgroundBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelBackgroundLoadVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelBackgroundCleanVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
