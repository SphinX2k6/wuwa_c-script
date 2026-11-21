using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005459 RID: 21593
	public static class IBubbleComponentVerify
	{
		// Token: 0x06021E6F RID: 138863 RVA: 0x004AC414 File Offset: 0x004AA614
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBubbleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBubbleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionBubbleDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					short offsetId2 = 22;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBubbleComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBubbleComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IBubbleRangeCylinderConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082E9 RID: 33513
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144E8 RID: 83176
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144E9 RID: 83177
			public static VerifyTableAction <1>__Verify;
		}
	}
}
