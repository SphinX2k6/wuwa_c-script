using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074EC RID: 29932
	public static class IUpdateTrialCharacterVerify
	{
		// Token: 0x060366DA RID: 222938 RVA: 0x0076506C File Offset: 0x0076326C
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

		// Token: 0x02007EBB RID: 32443
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C02 RID: 80898
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013C03 RID: 80899
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013C04 RID: 80900
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
