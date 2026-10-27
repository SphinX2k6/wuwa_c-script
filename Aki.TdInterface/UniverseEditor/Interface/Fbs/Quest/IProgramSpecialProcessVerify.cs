using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB8 RID: 16312
	public static class IProgramSpecialProcessVerify
	{
		// Token: 0x06017531 RID: 95537 RVA: 0x0035CB88 File Offset: 0x0035AD88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProgramSpecialProcessVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProgramSpecialProcessVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IProgramSpecialProcessVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IProgramSpecialProcessVerify.<>O.<1>__Verify = new VerifyTableAction(ILowMemorySceneSwitchVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007920 RID: 31008
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401320D RID: 78349
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401320E RID: 78350
			public static VerifyTableAction <1>__Verify;
		}
	}
}
