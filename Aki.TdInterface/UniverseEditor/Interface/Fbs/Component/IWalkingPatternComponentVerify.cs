using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B49 RID: 23369
	public static class IWalkingPatternComponentVerify
	{
		// Token: 0x06027F58 RID: 163672 RVA: 0x0057E6FC File Offset: 0x0057C8FC
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

		// Token: 0x02007C77 RID: 31863
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401379A RID: 79770
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401379B RID: 79771
			public static VerifyTableAction <1>__Verify;
		}
	}
}
