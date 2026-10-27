using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046ED RID: 18157
	public static class IEntityRunningDataVerify
	{
		// Token: 0x0601BC92 RID: 113810 RVA: 0x003F0518 File Offset: 0x003EE718
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

		// Token: 0x020079D3 RID: 31187
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401336F RID: 78703
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013370 RID: 78704
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013371 RID: 78705
			public static VerifyTableAction <2>__Verify;
		}
	}
}
