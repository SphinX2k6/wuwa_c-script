using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE2 RID: 31970
	public static class IUpdateTrialCharacterVerify
	{
		// Token: 0x06039AEF RID: 236271 RVA: 0x007C82BC File Offset: 0x007C64BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUpdateTrialCharacterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUpdateTrialCharacterVerify.<>O.<0>__Verify = new VerifyTableAction(ICharacterGroupNewVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IUpdateTrialCharacterVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IUpdateTrialCharacterVerify.<>O.<1>__Verify = new VerifyTableAction(IActiveRangeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 16, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						short typeIdVOffset = 20;
						short valueVOffset = 22;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IUpdateTrialCharacterVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IUpdateTrialCharacterVerify.<>O.<2>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008755 RID: 34645
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CDC RID: 85212
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CDD RID: 85213
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014CDE RID: 85214
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
