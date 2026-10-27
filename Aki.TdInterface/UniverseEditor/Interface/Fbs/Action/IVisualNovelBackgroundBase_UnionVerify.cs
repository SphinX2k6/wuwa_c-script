using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755E RID: 30046
	public static class IVisualNovelBackgroundBase_UnionVerify
	{
		// Token: 0x06036A99 RID: 223897 RVA: 0x0076C88C File Offset: 0x0076AA8C
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
