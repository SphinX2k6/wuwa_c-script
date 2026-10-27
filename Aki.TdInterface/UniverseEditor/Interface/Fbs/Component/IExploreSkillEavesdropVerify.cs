using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E2 RID: 20962
	public static class IExploreSkillEavesdropVerify
	{
		// Token: 0x06022005 RID: 139269 RVA: 0x004B760C File Offset: 0x004B580C
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

		// Token: 0x02007B0F RID: 31503
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401353A RID: 79162
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401353B RID: 79163
			public static VerifyTableAction <1>__Verify;
		}
	}
}
