using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC4 RID: 16324
	public static class IProgressCalculateVerify
	{
		// Token: 0x06017588 RID: 95624 RVA: 0x0035D6CC File Offset: 0x0035B8CC
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

		// Token: 0x02007922 RID: 31010
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013210 RID: 78352
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013211 RID: 78353
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
