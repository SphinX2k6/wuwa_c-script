using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D8 RID: 26072
	public static class IDisableBattleSkillOptionsVerify
	{
		// Token: 0x0602D385 RID: 185221 RVA: 0x00632B08 File Offset: 0x00630D08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDisableBattleSkillOptionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDisableBattleSkillOptionsVerify.<>O.<0>__Verify = new VerifyTableAction(IDisableCharacterSectionalSkillOptionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D41 RID: 32065
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138B6 RID: 80054
			public static VerifyTableAction <0>__Verify;
		}
	}
}
