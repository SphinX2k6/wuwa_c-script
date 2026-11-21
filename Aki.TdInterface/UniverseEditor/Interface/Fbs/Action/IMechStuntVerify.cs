using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AC RID: 29100
	public static class IMechStuntVerify
	{
		// Token: 0x060329F5 RID: 207349 RVA: 0x006D738C File Offset: 0x006D558C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMechStuntVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechStuntVerify.<>O.<0>__Verify = new VerifyUnionAction(TMechStuntConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMechStuntVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMechStuntVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008629 RID: 34345
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149F8 RID: 84472
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040149F9 RID: 84473
			public static VerifyTableAction <1>__Verify;
		}
	}
}
