using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Entity;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004711 RID: 18193
	public static class IRunningTreeConfigVerify
	{
		// Token: 0x0601BEE6 RID: 114406 RVA: 0x003F59AC File Offset: 0x003F3BAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunningTreeConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunningTreeConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRunningNodeStatusVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRunningTreeConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRunningTreeConfigVerify.<>O.<1>__Verify = new VerifyTableAction(Record_String_StringVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRunningTreeConfigVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IRunningTreeConfigVerify.<>O.<1>__Verify = new VerifyTableAction(Record_String_StringVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IRunningTreeConfigVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IRunningTreeConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IGameCurrBreakNodeInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 16, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 18, false))
							{
								short offsetId5 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IRunningTreeConfigVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IRunningTreeConfigVerify.<>O.<3>__Verify = new VerifyTableAction(Record_Int_EActionStateVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 22;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IRunningTreeConfigVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (IRunningTreeConfigVerify.<>O.<4>__Verify = new VerifyTableAction(IInstEntityDataVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 24;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IRunningTreeConfigVerify.<>O.<4>__Verify) == null)
										{
											verifyAction7 = (IRunningTreeConfigVerify.<>O.<4>__Verify = new VerifyTableAction(IInstEntityDataVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
										{
											return verifier.VerifyTableEnd(tablePos);
										}
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020079D9 RID: 31193
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401337C RID: 78716
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401337D RID: 78717
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401337E RID: 78718
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401337F RID: 78719
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013380 RID: 78720
			public static VerifyTableAction <4>__Verify;
		}
	}
}
