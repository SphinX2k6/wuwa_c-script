using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA6 RID: 20134
	public static class IAnimalComponentVerify
	{
		// Token: 0x0601FB3B RID: 129851 RVA: 0x0046A0D8 File Offset: 0x004682D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAnimalComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAnimalComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICollectAnimalConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 20;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAnimalComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAnimalComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IAnimalEmotionBubbleEntryVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A7F RID: 31359
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401344F RID: 78927
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013450 RID: 78928
			public static VerifyTableAction <1>__Verify;
		}
	}
}
