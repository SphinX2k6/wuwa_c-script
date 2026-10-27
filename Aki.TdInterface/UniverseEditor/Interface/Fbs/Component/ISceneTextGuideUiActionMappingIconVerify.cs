using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E1 RID: 22753
	public static class ISceneTextGuideUiActionMappingIconVerify
	{
		// Token: 0x060266B1 RID: 157361 RVA: 0x0054B54B File Offset: 0x0054974B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
