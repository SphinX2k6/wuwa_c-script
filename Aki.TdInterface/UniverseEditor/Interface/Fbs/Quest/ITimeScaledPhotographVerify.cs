using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E3 RID: 16867
	public static class ITimeScaledPhotographVerify
	{
		// Token: 0x06018DE1 RID: 101857 RVA: 0x00393FB4 File Offset: 0x003921B4
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

		// Token: 0x0200796B RID: 31083
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132CE RID: 78542
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132CF RID: 78543
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132D0 RID: 78544
			public static VerifyTableAction <2>__Verify;
		}
	}
}
