using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427C RID: 17020
	public static class IFinishKurotatoConditionVerify
	{
		// Token: 0x06017BF8 RID: 97272 RVA: 0x00363444 File Offset: 0x00361644
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishKurotatoConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishKurotatoConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishKurotatoConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishKurotatoConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TKurotatoConditionStepVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 12;
						short valueVOffset2 = 14;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IFinishKurotatoConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFinishKurotatoConditionVerify.<>O.<2>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008127 RID: 33063
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141E9 RID: 82409
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141EA RID: 82410
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040141EB RID: 82411
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
