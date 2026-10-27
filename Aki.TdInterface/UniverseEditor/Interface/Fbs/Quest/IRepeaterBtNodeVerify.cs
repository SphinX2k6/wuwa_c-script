using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A5 RID: 16549
	public static class IRepeaterBtNodeVerify
	{
		// Token: 0x060181B4 RID: 98740 RVA: 0x00379D60 File Offset: 0x00377F60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRepeaterBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRepeaterBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short typeIdVOffset = 16;
					short valueVOffset = 18;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IRepeaterBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRepeaterBtNodeVerify.<>O.<1>__Verify = new VerifyUnionAction(TBtNodeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false))
					{
						short offsetId2 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRepeaterBtNodeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IRepeaterBtNodeVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200794A RID: 31050
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013269 RID: 78441
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401326A RID: 78442
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401326B RID: 78443
			public static VerifyTableAction <2>__Verify;
		}
	}
}
