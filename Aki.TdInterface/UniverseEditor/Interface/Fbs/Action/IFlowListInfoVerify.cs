using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681B RID: 26651
	public static class IFlowListInfoVerify
	{
		// Token: 0x0602E74F RID: 190287 RVA: 0x00657284 File Offset: 0x00655484
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowListInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowListInfoVerify.<>O.<0>__Verify = new VerifyTableAction(Record_Int_IFlowTextConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFlowListInfoVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFlowListInfoVerify.<>O.<1>__Verify = new VerifyTableAction(IFlowInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyVectorOfData(tablePos, 16, 2UL, false) && verifier.VerifyVectorOfData(tablePos, 18, 2UL, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyVectorOfStrings(tablePos, 24, false) && verifier.VerifyString(tablePos, 26, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D77 RID: 32119
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138FB RID: 80123
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138FC RID: 80124
			public static VerifyTableAction <1>__Verify;
		}
	}
}
