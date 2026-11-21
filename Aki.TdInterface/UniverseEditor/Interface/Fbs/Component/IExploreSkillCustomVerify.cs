using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005744 RID: 22340
	public static class IExploreSkillCustomVerify
	{
		// Token: 0x06023F3D RID: 147261 RVA: 0x004F11A8 File Offset: 0x004EF3A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExploreSkillCustomVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillCustomVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExploreSkillCustomVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IExploreSkillCustomVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008368 RID: 33640
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145B6 RID: 83382
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145B7 RID: 83383
			public static VerifyTableAction <1>__Verify;
		}
	}
}
