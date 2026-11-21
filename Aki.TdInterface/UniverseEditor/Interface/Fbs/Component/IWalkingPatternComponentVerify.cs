using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200615F RID: 24927
	public static class IWalkingPatternComponentVerify
	{
		// Token: 0x0602A51C RID: 173340 RVA: 0x005C618C File Offset: 0x005C438C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IWalkingPatternComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWalkingPatternComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 16, false))
				{
					short offsetId = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWalkingPatternComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWalkingPatternComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IWalkingPatternStayAwayConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084E8 RID: 34024
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014840 RID: 84032
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014841 RID: 84033
			public static VerifyTableAction <1>__Verify;
		}
	}
}
