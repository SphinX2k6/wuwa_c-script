using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC2 RID: 20162
	public static class ICheckEntityGravityDirectionVerify
	{
		// Token: 0x0601F470 RID: 128112 RVA: 0x0045C21C File Offset: 0x0045A41C
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

		// Token: 0x0200827A RID: 33402
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401445B RID: 83035
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401445C RID: 83036
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
