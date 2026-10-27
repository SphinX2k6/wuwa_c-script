using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051FD RID: 20989
	public static class IExploreSkillPullStatueVerify
	{
		// Token: 0x0602219D RID: 139677 RVA: 0x004BB904 File Offset: 0x004B9B04
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

		// Token: 0x02007B15 RID: 31509
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013548 RID: 79176
			public static VerifyTableAction <0>__Verify;
		}
	}
}
