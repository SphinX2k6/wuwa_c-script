using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E41 RID: 15937
	public static class IFinishKurotatoConditionVerify
	{
		// Token: 0x060165D1 RID: 91601 RVA: 0x0033A914 File Offset: 0x00338B14
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

		// Token: 0x020078E1 RID: 30945
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401318B RID: 78219
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401318C RID: 78220
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401318D RID: 78221
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
