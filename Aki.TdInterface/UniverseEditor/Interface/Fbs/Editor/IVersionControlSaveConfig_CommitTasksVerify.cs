using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D29 RID: 19753
	public static class IVersionControlSaveConfig_CommitTasksVerify
	{
		// Token: 0x0601E9E4 RID: 125412 RVA: 0x00449318 File Offset: 0x00447518
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVersionControlSaveConfig_CommitTasksVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVersionControlSaveConfig_CommitTasksVerify.<>O.<0>__Verify = new VerifyTableAction(IVersionControlSaveConfig_CommitTasks_SwarmRequestStatusVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyVectorOfStrings(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 8UL, 8UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008260 RID: 33376
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401443E RID: 83006
			public static VerifyTableAction <0>__Verify;
		}
	}
}
