using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E79 RID: 20089
	public static class IAiComponentVerify
	{
		// Token: 0x0601F94D RID: 129357 RVA: 0x00466228 File Offset: 0x00464428
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAiComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAiComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPatrolVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IAiComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAiComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TInitStateVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 16, 1UL, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false))
					{
						short offsetId2 = 24;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAiComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IAiComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IStateRepPerfItemVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 26;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IAiComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IAiComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IAiAlertSystemConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007A76 RID: 31350
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013443 RID: 78915
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013444 RID: 78916
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04013445 RID: 78917
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013446 RID: 78918
			public static VerifyTableAction <3>__Verify;
		}
	}
}
