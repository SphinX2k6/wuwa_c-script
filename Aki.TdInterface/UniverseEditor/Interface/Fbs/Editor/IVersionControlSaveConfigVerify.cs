using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C1 RID: 18625
	public static class IVersionControlSaveConfigVerify
	{
		// Token: 0x0601D1B7 RID: 119223 RVA: 0x0041C160 File Offset: 0x0041A360
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVersionControlSaveConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVersionControlSaveConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICommitLogVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IVersionControlSaveConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVersionControlSaveConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ISpecificLevelScanDataVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IVersionControlSaveConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IVersionControlSaveConfigVerify.<>O.<2>__Verify = new VerifyTableAction(ICustomScanDirectoryDataVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IVersionControlSaveConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IVersionControlSaveConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IVersionControlSaveConfig_CommitTasksVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007A16 RID: 31254
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133D4 RID: 78804
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040133D5 RID: 78805
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040133D6 RID: 78806
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040133D7 RID: 78807
			public static VerifyTableAction <3>__Verify;
		}
	}
}
