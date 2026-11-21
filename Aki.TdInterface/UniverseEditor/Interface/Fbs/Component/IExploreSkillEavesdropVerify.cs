using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005747 RID: 22343
	public static class IExploreSkillEavesdropVerify
	{
		// Token: 0x06023F5D RID: 147293 RVA: 0x004F1674 File Offset: 0x004EF874
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExploreSkillEavesdropVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillEavesdropVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExploreSkillEavesdropVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IExploreSkillEavesdropVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008369 RID: 33641
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145B8 RID: 83384
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145B9 RID: 83385
			public static VerifyTableAction <1>__Verify;
		}
	}
}
