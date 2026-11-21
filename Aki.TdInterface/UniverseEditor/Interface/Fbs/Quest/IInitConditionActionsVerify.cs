using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F4 RID: 17140
	public static class IInitConditionActionsVerify
	{
		// Token: 0x0601811D RID: 98589 RVA: 0x0036F1B0 File Offset: 0x0036D3B0
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

		// Token: 0x0200813E RID: 33086
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014213 RID: 82451
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014214 RID: 82452
			public static VerifyTableAction <1>__Verify;
		}
	}
}
