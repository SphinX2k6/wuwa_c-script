using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A02 RID: 18946
	public static class ICheckEntityGravityDirectionVerify
	{
		// Token: 0x0601D9FD RID: 121341 RVA: 0x0042B5B0 File Offset: 0x004297B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckEntityGravityDirectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEntityGravityDirectionVerify.<>O.<0>__Verify = new VerifyUnionAction(TCheckTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICheckEntityGravityDirectionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckEntityGravityDirectionVerify.<>O.<1>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A2B RID: 31275
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133EE RID: 78830
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040133EF RID: 78831
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
