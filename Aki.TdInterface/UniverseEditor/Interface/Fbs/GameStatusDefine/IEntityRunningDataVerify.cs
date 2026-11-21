using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B55 RID: 19285
	public static class IEntityRunningDataVerify
	{
		// Token: 0x0601D467 RID: 119911 RVA: 0x0041C7B4 File Offset: 0x0041A9B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 22, false))
			{
				short offsetId = 24;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityRunningDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityRunningDataVerify.<>O.<0>__Verify = new VerifyTableAction(Record_String_StringVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 26, 4UL, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityRunningDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityRunningDataVerify.<>O.<1>__Verify = new VerifyTableAction(Record_Int_EActionStateVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IEntityRunningDataVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IEntityRunningDataVerify.<>O.<2>__Verify = new VerifyTableAction(Record_Int_IntVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200821C RID: 33308
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143D6 RID: 82902
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143D7 RID: 82903
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040143D8 RID: 82904
			public static VerifyTableAction <2>__Verify;
		}
	}
}
