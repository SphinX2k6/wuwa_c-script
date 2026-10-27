using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006818 RID: 26648
	public static class IFlowInfoVerify
	{
		// Token: 0x0602E6E1 RID: 190177 RVA: 0x0065616C File Offset: 0x0065436C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
			{
				short typeIdVOffset = 22;
				short valueVOffset = 24;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFlowInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowInfoVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarContextVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 26;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFlowInfoVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFlowInfoVerify.<>O.<1>__Verify = new VerifyTableAction(IStateInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D76 RID: 32118
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F9 RID: 80121
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040138FA RID: 80122
			public static VerifyTableAction <1>__Verify;
		}
	}
}
