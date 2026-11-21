using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DFC RID: 32252
	public static class IVisualNovelTransitionPerformanceConfigBase_UnionVerify
	{
		// Token: 0x0603A47E RID: 238718 RVA: 0x007DA334 File Offset: 0x007D8534
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVisualNovelTransitionPerformanceSolarSchoolVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVisualNovelTransitionPerformanceConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
