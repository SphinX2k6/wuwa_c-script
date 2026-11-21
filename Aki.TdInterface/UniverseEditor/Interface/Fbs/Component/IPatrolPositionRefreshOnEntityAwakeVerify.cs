using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D07 RID: 23815
	public static class IPatrolPositionRefreshOnEntityAwakeVerify
	{
		// Token: 0x060278E5 RID: 162021 RVA: 0x00569646 File Offset: 0x00567846
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
