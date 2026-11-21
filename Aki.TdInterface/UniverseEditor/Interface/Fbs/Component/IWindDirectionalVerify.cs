using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006192 RID: 24978
	public static class IWindDirectionalVerify
	{
		// Token: 0x0602A73E RID: 173886 RVA: 0x005CA92C File Offset: 0x005C8B2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWindDirectionalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWindDirectionalVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWindDirectionalVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWindDirectionalVerify.<>O.<1>__Verify = new VerifyTableAction(IWindDirectionalStateGradeVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084F1 RID: 34033
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401484F RID: 84047
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014850 RID: 84048
			public static VerifyTableAction <1>__Verify;
		}
	}
}
