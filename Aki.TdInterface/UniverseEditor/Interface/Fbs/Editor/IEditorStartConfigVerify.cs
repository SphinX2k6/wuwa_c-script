using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004870 RID: 18544
	public static class IEditorStartConfigVerify
	{
		// Token: 0x0601CDD3 RID: 118227 RVA: 0x00414358 File Offset: 0x00412558
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 36, false) && verifier.VerifyField(tablePos, 38, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 40, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 46, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 48, false) && verifier.VerifyField(tablePos, 50, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 54, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 56, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 58, false) && verifier.VerifyVectorOfStrings(tablePos, 60, false))
			{
				short offsetId = 62;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEditorStartConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEditorStartConfigVerify.<>O.<0>__Verify = new VerifyTableAction(Record_Int_StringsVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 64;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEditorStartConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEditorStartConfigVerify.<>O.<1>__Verify = new VerifyTableAction(Record_Int_IntsVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 66;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IEditorStartConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IEditorStartConfigVerify.<>O.<2>__Verify = new VerifyTableAction(Record_Int_IDisableEntitiesVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 68;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IEditorStartConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IEditorStartConfigVerify.<>O.<3>__Verify = new VerifyTableAction(Record_Int_IntVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyVectorOfData(tablePos, 70, 4UL, false) && verifier.VerifyField(tablePos, 72, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 74, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 76, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 78, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 80, 1UL, 1UL, false))
							{
								short offsetId5 = 82;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IEditorStartConfigVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IEditorStartConfigVerify.<>O.<4>__Verify = new VerifyTableAction(IPosAVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 84, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 86, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 88, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 90, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007A10 RID: 31248
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133C9 RID: 78793
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040133CA RID: 78794
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040133CB RID: 78795
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040133CC RID: 78796
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040133CD RID: 78797
			public static VerifyTableAction <4>__Verify;
		}
	}
}
