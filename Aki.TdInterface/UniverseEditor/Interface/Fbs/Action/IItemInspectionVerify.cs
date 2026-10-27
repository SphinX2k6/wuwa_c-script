using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CB RID: 27083
	public static class IItemInspectionVerify
	{
		// Token: 0x0602F562 RID: 193890 RVA: 0x006724E4 File Offset: 0x006706E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IItemInspectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemInspectionVerify.<>O.<0>__Verify = new VerifyTableAction(ISequenceUnlockPointsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IItemInspectionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IItemInspectionVerify.<>O.<1>__Verify = new VerifyTableAction(IConeRangeCheckVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IItemInspectionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IItemInspectionVerify.<>O.<2>__Verify = new VerifyTableAction(IAstrologyTextUiConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IItemInspectionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IItemInspectionVerify.<>O.<3>__Verify = new VerifyTableAction(IItemInspectFinishEffectVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007D95 RID: 32149
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013925 RID: 80165
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013926 RID: 80166
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013927 RID: 80167
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013928 RID: 80168
			public static VerifyTableAction <3>__Verify;
		}
	}
}
