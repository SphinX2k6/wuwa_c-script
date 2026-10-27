using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D9 RID: 21465
	public static class IHookPerformanceConfigVerify
	{
		// Token: 0x060233A0 RID: 144288 RVA: 0x004E0BB5 File Offset: 0x004DEDB5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
