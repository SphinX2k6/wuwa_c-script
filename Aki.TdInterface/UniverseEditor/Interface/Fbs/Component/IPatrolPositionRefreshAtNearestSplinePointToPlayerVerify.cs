using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D01 RID: 23809
	public static class IPatrolPositionRefreshAtNearestSplinePointToPlayerVerify
	{
		// Token: 0x060278AD RID: 161965 RVA: 0x00568E82 File Offset: 0x00567082
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
