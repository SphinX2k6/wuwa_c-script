using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200613C RID: 24892
	public static class IAddTrialCharacterVerify
	{
		// Token: 0x0602A978 RID: 174456 RVA: 0x005DD788 File Offset: 0x005DB988
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddTrialCharacterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddTrialCharacterVerify.<>O.<0>__Verify = new VerifyTableAction(ICharacterGroupNewVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short offsetId2 = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAddTrialCharacterVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAddTrialCharacterVerify.<>O.<1>__Verify = new VerifyTableAction(IActiveRangeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 20, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 24, 4UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
					{
						short typeIdVOffset = 28;
						short valueVOffset = 30;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IAddTrialCharacterVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IAddTrialCharacterVerify.<>O.<2>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 2UL, 2UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007CDF RID: 31967
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013814 RID: 79892
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013815 RID: 79893
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013816 RID: 79894
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
