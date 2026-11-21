using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA0 RID: 28576
	public static class IHideHighlightExploreSkillIconVerify
	{
		// Token: 0x06031792 RID: 202642 RVA: 0x006B4E28 File Offset: 0x006B3028
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHideHighlightExploreSkillIconVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHideHighlightExploreSkillIconVerify.<>O.<0>__Verify = new VerifyTableAction(IHideHighlightExploreSkillIconTargetConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008602 RID: 34306
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149BF RID: 84415
			public static VerifyTableAction <0>__Verify;
		}
	}
}
