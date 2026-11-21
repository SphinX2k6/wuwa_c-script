using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D4B RID: 23883
	public static class IPilotThrowTargetVerify
	{
		// Token: 0x06027C14 RID: 162836 RVA: 0x00570998 File Offset: 0x0056EB98
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

		// Token: 0x02008448 RID: 33864
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401473B RID: 83771
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401473C RID: 83772
			public static VerifyTableAction <1>__Verify;
		}
	}
}
