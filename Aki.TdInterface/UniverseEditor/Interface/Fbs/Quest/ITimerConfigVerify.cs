using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DA RID: 16858
	public static class ITimerConfigVerify
	{
		// Token: 0x06018D76 RID: 101750 RVA: 0x00392FD8 File Offset: 0x003911D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITimerConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimerConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimerConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimerConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ITimerUiConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007969 RID: 31081
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132C9 RID: 78537
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040132CA RID: 78538
			public static VerifyTableAction <1>__Verify;
		}
	}
}
