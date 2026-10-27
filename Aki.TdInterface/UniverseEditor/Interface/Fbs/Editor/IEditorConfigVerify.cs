using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200485B RID: 18523
	public static class IEditorConfigVerify
	{
		// Token: 0x0601CBB5 RID: 117685 RVA: 0x0040FA28 File Offset: 0x0040DC28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEditorConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEditorConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowStateIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 16, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
				{
					short offsetId2 = 32;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEditorConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEditorConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ILaunchSettingShowInMainEditorVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 34;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IEditorConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IEditorConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IEditorStartConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 36;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IEditorConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IEditorConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IEditorIndentationDisplaySettingVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 46, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 52, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 54, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 56, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 58, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
							{
								short offsetId5 = 64;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IEditorConfigVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IEditorConfigVerify.<>O.<4>__Verify = new VerifyTableAction(Record_String_BooleanVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 66;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IEditorConfigVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (IEditorConfigVerify.<>O.<4>__Verify = new VerifyTableAction(Record_String_BooleanVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyField(tablePos, 68, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 70, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 72, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 74, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 76, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 78, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 80, false) && verifier.VerifyString(tablePos, 82, false))
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

		// Token: 0x02007A0E RID: 31246
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133C3 RID: 78787
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040133C4 RID: 78788
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040133C5 RID: 78789
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040133C6 RID: 78790
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040133C7 RID: 78791
			public static VerifyTableAction <4>__Verify;
		}
	}
}
