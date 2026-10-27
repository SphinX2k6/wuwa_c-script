using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C7 RID: 18631
	public static class IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusVerify
	{
		// Token: 0x0601D20F RID: 119311 RVA: 0x0041CE2F File Offset: 0x0041B02F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
