using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051A7 RID: 20903
	public static class IRangeSphereVerify
	{
		// Token: 0x06020E80 RID: 134784 RVA: 0x0048D640 File Offset: 0x0048B840
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRangeSphereVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRangeSphereVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IRangeSphereVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRangeSphereVerify.<>O.<1>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082B8 RID: 33464
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401449E RID: 83102
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401449F RID: 83103
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
