using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C64 RID: 27748
	public static class IDisableSectionalSkillOperationVerify
	{
		// Token: 0x0602FCB5 RID: 195765 RVA: 0x006824D8 File Offset: 0x006806D8
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

		// Token: 0x020085BA RID: 34234
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014968 RID: 84328
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014969 RID: 84329
			public static VerifyTableAction <1>__Verify;
		}
	}
}
