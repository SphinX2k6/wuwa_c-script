using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F00 RID: 24320
	public static class ISearchlightRotateVerify
	{
		// Token: 0x06028CE5 RID: 167141 RVA: 0x00593AD8 File Offset: 0x00591CD8
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

		// Token: 0x02008495 RID: 33941
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147AC RID: 83884
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147AD RID: 83885
			public static VerifyTableAction <1>__Verify;
		}
	}
}
