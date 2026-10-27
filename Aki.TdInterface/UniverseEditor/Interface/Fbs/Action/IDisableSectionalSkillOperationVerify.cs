using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F3 RID: 26099
	public static class IDisableSectionalSkillOperationVerify
	{
		// Token: 0x0602D4E4 RID: 185572 RVA: 0x00635970 File Offset: 0x00633B70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDisableSectionalSkillOperationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDisableSectionalSkillOperationVerify.<>O.<0>__Verify = new VerifyTableAction(IDisableExploreSkillVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDisableSectionalSkillOperationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDisableSectionalSkillOperationVerify.<>O.<1>__Verify = new VerifyTableAction(IDisableBattleSkillOptionsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D43 RID: 32067
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138BC RID: 80060
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138BD RID: 80061
			public static VerifyTableAction <1>__Verify;
		}
	}
}
