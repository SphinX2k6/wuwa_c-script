using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D4B RID: 32075
	public static class IVisualNovelActivityActionConfigBase_UnionVerify
	{
		// Token: 0x06039E79 RID: 237177 RVA: 0x007CF688 File Offset: 0x007CD888
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
