using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005501 RID: 21761
	public static class IClientConditionListenerVerify
	{
		// Token: 0x060225F8 RID: 140792 RVA: 0x004BC95C File Offset: 0x004BAB5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientConditionListenerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientConditionListenerVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IClientConditionListenerVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IClientConditionListenerVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200830A RID: 33546
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401451A RID: 83226
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401451B RID: 83227
			public static VerifyTableAction <1>__Verify;
		}
	}
}
