using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707B RID: 28795
	public static class IItemInspectionVerify
	{
		// Token: 0x06031F22 RID: 204578 RVA: 0x006C283C File Offset: 0x006C0A3C
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

		// Token: 0x0200860F RID: 34319
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149D5 RID: 84437
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149D6 RID: 84438
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040149D7 RID: 84439
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040149D8 RID: 84440
			public static VerifyTableAction <3>__Verify;
		}
	}
}
