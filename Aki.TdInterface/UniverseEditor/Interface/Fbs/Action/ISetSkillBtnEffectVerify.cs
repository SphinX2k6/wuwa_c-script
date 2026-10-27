using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706F RID: 28783
	public static class ISetSkillBtnEffectVerify
	{
		// Token: 0x06032F73 RID: 208755 RVA: 0x006E0024 File Offset: 0x006DE224
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 2UL, 2UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetSkillBtnEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetSkillBtnEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IMusicBattleBtnEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E4E RID: 32334
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A23 RID: 80419
			public static VerifyTableAction <0>__Verify;
		}
	}
}
