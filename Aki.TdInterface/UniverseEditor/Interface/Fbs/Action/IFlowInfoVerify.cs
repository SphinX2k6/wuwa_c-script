using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E98 RID: 28312
	public static class IFlowInfoVerify
	{
		// Token: 0x06030F33 RID: 200499 RVA: 0x006A3A5C File Offset: 0x006A1C5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 22, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
			{
				short typeIdVOffset = 24;
				short valueVOffset = 26;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFlowInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowInfoVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarContextVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFlowInfoVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFlowInfoVerify.<>O.<1>__Verify = new VerifyTableAction(IStateInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020085ED RID: 34285
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149A5 RID: 84389
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040149A6 RID: 84390
			public static VerifyTableAction <1>__Verify;
		}
	}
}
