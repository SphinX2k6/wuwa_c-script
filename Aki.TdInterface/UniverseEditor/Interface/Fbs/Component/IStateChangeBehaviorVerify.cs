using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A0 RID: 22944
	public static class IStateChangeBehaviorVerify
	{
		// Token: 0x06026DDF RID: 159199 RVA: 0x0055952C File Offset: 0x0055772C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStateChangeBehaviorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStateChangeBehaviorVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStateChangeBehaviorVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStateChangeBehaviorVerify.<>O.<1>__Verify = new VerifyTableAction(IDelayChangeStateVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IStateChangeBehaviorVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IStateChangeBehaviorVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionActionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C3B RID: 31803
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013727 RID: 79655
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013728 RID: 79656
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013729 RID: 79657
			public static VerifyTableAction <2>__Verify;
		}
	}
}
