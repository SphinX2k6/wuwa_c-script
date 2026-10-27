using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051DF RID: 20959
	public static class IExploreSkillCustomVerify
	{
		// Token: 0x06021FE5 RID: 139237 RVA: 0x004B7140 File Offset: 0x004B5340
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

		// Token: 0x02007B0E RID: 31502
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013538 RID: 79160
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013539 RID: 79161
			public static VerifyTableAction <1>__Verify;
		}
	}
}
