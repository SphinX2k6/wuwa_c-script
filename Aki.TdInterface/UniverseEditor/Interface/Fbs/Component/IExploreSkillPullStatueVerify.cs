using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005765 RID: 22373
	public static class IExploreSkillPullStatueVerify
	{
		// Token: 0x06024133 RID: 147763 RVA: 0x004F63C8 File Offset: 0x004F45C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExploreSkillPullStatueVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillPullStatueVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008370 RID: 33648
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145C8 RID: 83400
			public static VerifyTableAction <0>__Verify;
		}
	}
}
