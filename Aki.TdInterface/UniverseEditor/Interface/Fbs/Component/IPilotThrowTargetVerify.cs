using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005744 RID: 22340
	public static class IPilotThrowTargetVerify
	{
		// Token: 0x060256F4 RID: 153332 RVA: 0x0052A80C File Offset: 0x00528A0C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPilotThrowTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPilotThrowTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPilotThrowTargetVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPilotThrowTargetVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BDA RID: 31706
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401369B RID: 79515
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401369C RID: 79516
			public static VerifyTableAction <1>__Verify;
		}
	}
}
