using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D2D RID: 15661
	public static class IBehaviorTreeVerify
	{
		// Token: 0x06015A0E RID: 88590 RVA: 0x0031F4E0 File Offset: 0x0031D6E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBehaviorTreeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBehaviorTreeVerify.<>O.<0>__Verify = new VerifyTableAction(IVarDefineVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBehaviorTreeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBehaviorTreeVerify.<>O.<1>__Verify = new VerifyTableAction(IStartBtNodeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBehaviorTreeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IBehaviorTreeVerify.<>O.<2>__Verify = new VerifyTableAction(IFavoriteBtNodeInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020078B2 RID: 30898
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013128 RID: 78120
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013129 RID: 78121
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401312A RID: 78122
			public static VerifyTableAction <2>__Verify;
		}
	}
}
