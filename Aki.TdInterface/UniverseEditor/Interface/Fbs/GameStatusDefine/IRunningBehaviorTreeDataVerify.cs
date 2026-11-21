using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B67 RID: 19303
	public static class IRunningBehaviorTreeDataVerify
	{
		// Token: 0x0601D58F RID: 120207 RVA: 0x0041F060 File Offset: 0x0041D260
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunningBehaviorTreeDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunningBehaviorTreeDataVerify.<>O.<0>__Verify = new VerifyTableAction(IRunningQuestsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRunningBehaviorTreeDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRunningBehaviorTreeDataVerify.<>O.<1>__Verify = new VerifyTableAction(IRunningTreeVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRunningBehaviorTreeDataVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IRunningBehaviorTreeDataVerify.<>O.<2>__Verify = new VerifyTableAction(Record_String_StringVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IRunningBehaviorTreeDataVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IRunningBehaviorTreeDataVerify.<>O.<3>__Verify = new VerifyTableAction(IGameCurrBreakNodeEventInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 16;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IRunningBehaviorTreeDataVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IRunningBehaviorTreeDataVerify.<>O.<4>__Verify = new VerifyTableAction(IHideRangeInfoVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyString(tablePos, 18, false))
								{
									short offsetId6 = 20;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IRunningBehaviorTreeDataVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IRunningBehaviorTreeDataVerify.<>O.<5>__Verify = new VerifyTableAction(Record_String_IRunningFlowInfoVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
									{
										return verifier.VerifyTableEnd(tablePos);
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200821E RID: 33310
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143DA RID: 82906
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143DB RID: 82907
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040143DC RID: 82908
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040143DD RID: 82909
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040143DE RID: 82910
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040143DF RID: 82911
			public static VerifyTableAction <5>__Verify;
		}
	}
}
