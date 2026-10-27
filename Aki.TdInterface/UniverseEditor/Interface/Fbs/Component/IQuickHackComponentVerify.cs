using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CB RID: 22475
	public static class IQuickHackComponentVerify
	{
		// Token: 0x06025BAF RID: 154543 RVA: 0x00534010 File Offset: 0x00532210
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

		// Token: 0x02007BF0 RID: 31728
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136B9 RID: 79545
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136BA RID: 79546
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040136BB RID: 79547
			public static VerifyTableAction <2>__Verify;
		}
	}
}
