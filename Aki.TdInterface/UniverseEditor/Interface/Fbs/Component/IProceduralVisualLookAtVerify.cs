using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579B RID: 22427
	public static class IProceduralVisualLookAtVerify
	{
		// Token: 0x060259CA RID: 154058 RVA: 0x00530038 File Offset: 0x0052E238
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProceduralVisualLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProceduralVisualLookAtVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IProceduralVisualLookAtVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IProceduralVisualLookAtVerify.<>O.<1>__Verify = new VerifyUnionAction(TLookAtTargetVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BE8 RID: 31720
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136AD RID: 79533
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136AE RID: 79534
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
