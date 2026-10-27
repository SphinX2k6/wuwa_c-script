using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005131 RID: 20785
	public static class IElementalMatchActionsVerify
	{
		// Token: 0x0602186D RID: 137325 RVA: 0x004A7BB8 File Offset: 0x004A5DB8
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

		// Token: 0x02007AF0 RID: 31472
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401350D RID: 79117
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401350E RID: 79118
			public static VerifyTableAction <1>__Verify;
		}
	}
}
