using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F3 RID: 22771
	public static class ISearchlightRotateVerify
	{
		// Token: 0x0602677B RID: 157563 RVA: 0x0054CE6C File Offset: 0x0054B06C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISearchlightRotateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISearchlightRotateVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISearchlightRotateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISearchlightRotateVerify.<>O.<1>__Verify = new VerifyTableAction(ISnapAngleConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C26 RID: 31782
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401370A RID: 79626
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401370B RID: 79627
			public static VerifyTableAction <1>__Verify;
		}
	}
}
