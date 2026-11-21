using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D0A RID: 23818
	public static class IPatrolPositionRefreshOnEntityVisibilityShownVerify
	{
		// Token: 0x060278F7 RID: 162039 RVA: 0x005697BE File Offset: 0x005679BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
