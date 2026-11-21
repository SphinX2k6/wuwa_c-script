using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555E RID: 21854
	public static class ICondtionListenerVerify
	{
		// Token: 0x06022B1C RID: 142108 RVA: 0x004C7740 File Offset: 0x004C5940
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICondtionListenerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICondtionListenerVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICondtionListenerVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICondtionListenerVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICondtionListenerVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ICondtionListenerVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionActionVerify.Verify));
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

		// Token: 0x0200831C RID: 33564
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014534 RID: 83252
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014535 RID: 83253
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014536 RID: 83254
			public static VerifyTableAction <2>__Verify;
		}
	}
}
