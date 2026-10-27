using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006524 RID: 25892
	public static class ICycleMoveToPointsVerify
	{
		// Token: 0x0602CEC0 RID: 184000 RVA: 0x0062B4B8 File Offset: 0x006296B8
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

		// Token: 0x02007D3A RID: 32058
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138AC RID: 80044
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138AD RID: 80045
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
