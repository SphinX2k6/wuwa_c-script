using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD2 RID: 24018
	public static class IQuickHackComponentVerify
	{
		// Token: 0x060280CF RID: 164047 RVA: 0x0057A19C File Offset: 0x0057839C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuickHackComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuickHackComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuickHackComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuickHackComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IQuickHackSkillVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuickHackComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuickHackComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IQuickHackLinkEffectVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200845E RID: 33886
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014759 RID: 83801
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401475A RID: 83802
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401475B RID: 83803
			public static VerifyTableAction <2>__Verify;
		}
	}
}
