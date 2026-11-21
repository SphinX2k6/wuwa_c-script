using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D2C RID: 19756
	public static class IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusVerify
	{
		// Token: 0x0601E9FC RID: 125436 RVA: 0x004495CB File Offset: 0x004477CB
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
