using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D0D RID: 23821
	public static class IPatrolPositionRefreshTriggerVerify
	{
		// Token: 0x06027909 RID: 162057 RVA: 0x00569936 File Offset: 0x00567B36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
