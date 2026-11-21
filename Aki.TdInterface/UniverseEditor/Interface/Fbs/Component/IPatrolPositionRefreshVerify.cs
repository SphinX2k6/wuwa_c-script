using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CFE RID: 23806
	public static class IPatrolPositionRefreshVerify
	{
		// Token: 0x0602789B RID: 161947 RVA: 0x00568D0A File Offset: 0x00566F0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
