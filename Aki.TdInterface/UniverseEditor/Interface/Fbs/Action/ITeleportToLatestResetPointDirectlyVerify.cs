using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007390 RID: 29584
	public static class ITeleportToLatestResetPointDirectlyVerify
	{
		// Token: 0x06035B30 RID: 219952 RVA: 0x0074F92A File Offset: 0x0074DB2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
