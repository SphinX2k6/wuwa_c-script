using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200463C RID: 17980
	public static class ITimeScaledPhotographVerify
	{
		// Token: 0x0601A537 RID: 107831 RVA: 0x003BF408 File Offset: 0x003BD608
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeScaledPhotographVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeScaledPhotographVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimeScaledPhotographVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimeScaledPhotographVerify.<>O.<1>__Verify = new VerifyTableAction(IPhotographConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITimeScaledPhotographVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITimeScaledPhotographVerify.<>O.<2>__Verify = new VerifyTableAction(ICameraConditionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020081B4 RID: 33204
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014334 RID: 82740
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014335 RID: 82741
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014336 RID: 82742
			public static VerifyTableAction <2>__Verify;
		}
	}
}
