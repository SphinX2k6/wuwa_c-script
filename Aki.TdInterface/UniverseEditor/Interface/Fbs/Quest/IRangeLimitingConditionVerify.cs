using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004069 RID: 16489
	public static class IRangeLimitingConditionVerify
	{
		// Token: 0x06017F2E RID: 98094 RVA: 0x00374B28 File Offset: 0x00372D28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRangeLimitingConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRangeLimitingConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 18, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 20, 4UL, false))
				{
					short offsetId2 = 22;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRangeLimitingConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRangeLimitingConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IWarningPreformVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 24, 4UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007944 RID: 31044
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401325F RID: 78431
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013260 RID: 78432
			public static VerifyTableAction <1>__Verify;
		}
	}
}
