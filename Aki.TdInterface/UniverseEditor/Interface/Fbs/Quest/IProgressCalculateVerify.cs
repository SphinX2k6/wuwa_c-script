using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004405 RID: 17413
	public static class IProgressCalculateVerify
	{
		// Token: 0x06018C17 RID: 101399 RVA: 0x003872E4 File Offset: 0x003854E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IProgressCalculateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProgressCalculateVerify.<>O.<0>__Verify = new VerifyUnionAction(TProgressBarLeftTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IProgressCalculateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IProgressCalculateVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008169 RID: 33129
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014272 RID: 82546
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014273 RID: 82547
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
