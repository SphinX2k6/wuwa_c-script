using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007558 RID: 30040
	public static class IVisualNovelActivityActionSolarSchoolVerify
	{
		// Token: 0x06036A79 RID: 223865 RVA: 0x0076C5E0 File Offset: 0x0076A7E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
