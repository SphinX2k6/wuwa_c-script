using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005696 RID: 22166
	public static class IElementalMatchActionsVerify
	{
		// Token: 0x060237C1 RID: 145345 RVA: 0x004E1B44 File Offset: 0x004DFD44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IElementalMatchActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IElementalMatchActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IElementalMatchActionsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IElementalMatchActionsVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200834A RID: 33610
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401458B RID: 83339
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401458C RID: 83340
			public static VerifyTableAction <1>__Verify;
		}
	}
}
