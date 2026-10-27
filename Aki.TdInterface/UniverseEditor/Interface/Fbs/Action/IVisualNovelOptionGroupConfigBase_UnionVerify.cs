using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007591 RID: 30097
	public static class IVisualNovelOptionGroupConfigBase_UnionVerify
	{
		// Token: 0x06036BF3 RID: 224243 RVA: 0x0076E890 File Offset: 0x0076CA90
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVisualNovelOptionGroupSolarSchoolExamVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVisualNovelOptionGroupConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
