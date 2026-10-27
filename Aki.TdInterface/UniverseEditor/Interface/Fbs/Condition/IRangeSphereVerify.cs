using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CAE RID: 19630
	public static class IRangeSphereVerify
	{
		// Token: 0x0601F25E RID: 127582 RVA: 0x00459AF0 File Offset: 0x00457CF0
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

		// Token: 0x02007A66 RID: 31334
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401342E RID: 78894
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401342F RID: 78895
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
