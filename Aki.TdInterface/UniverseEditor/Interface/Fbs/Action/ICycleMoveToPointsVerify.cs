using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B92 RID: 27538
	public static class ICycleMoveToPointsVerify
	{
		// Token: 0x0602F65E RID: 194142 RVA: 0x00677964 File Offset: 0x00675B64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICycleMoveToPointsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICycleMoveToPointsVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICycleMoveToPointsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICycleMoveToPointsVerify.<>O.<1>__Verify = new VerifyUnionAction(TMoveToPointTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020085B0 RID: 34224
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014958 RID: 84312
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014959 RID: 84313
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
