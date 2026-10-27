using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C4 RID: 18628
	public static class IVersionControlSaveConfig_CommitTasksVerify
	{
		// Token: 0x0601D1F7 RID: 119287 RVA: 0x0041CB7C File Offset: 0x0041AD7C
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

		// Token: 0x02007A17 RID: 31255
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133D8 RID: 78808
			public static VerifyTableAction <0>__Verify;
		}
	}
}
