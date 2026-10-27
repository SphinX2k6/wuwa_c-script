using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB6 RID: 16054
	public static class IInitConditionActionsVerify
	{
		// Token: 0x06016AD0 RID: 92880 RVA: 0x00346228 File Offset: 0x00344428
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInitConditionActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInitConditionActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IInitConditionActionsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IInitConditionActionsVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078F8 RID: 30968
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131B5 RID: 78261
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131B6 RID: 78262
			public static VerifyTableAction <1>__Verify;
		}
	}
}
