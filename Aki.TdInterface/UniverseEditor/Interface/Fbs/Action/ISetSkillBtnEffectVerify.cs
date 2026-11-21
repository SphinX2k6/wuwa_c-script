using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200783B RID: 30779
	public static class ISetSkillBtnEffectVerify
	{
		// Token: 0x06036214 RID: 221716 RVA: 0x007405D8 File Offset: 0x0073E7D8
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

		// Token: 0x020086E4 RID: 34532
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AF7 RID: 84727
			public static VerifyTableAction <0>__Verify;
		}
	}
}
