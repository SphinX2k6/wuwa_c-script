using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007555 RID: 30037
	public static class IVisualNovelActivityActionConfigBase_UnionVerify
	{
		// Token: 0x06036A63 RID: 223843 RVA: 0x0076C3E0 File Offset: 0x0076A5E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVisualNovelActivityActionSolarSchoolVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVisualNovelActivityActionConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
