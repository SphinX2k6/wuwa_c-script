using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075EE RID: 30190
	public static class IVisualNovelTransitionPerformanceConfigBase_UnionVerify
	{
		// Token: 0x06036FD9 RID: 225241 RVA: 0x00776238 File Offset: 0x00774438
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
