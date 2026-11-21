using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004273 RID: 17011
	public static class IFinishFlipperConditionVerify
	{
		// Token: 0x06017B7F RID: 97151 RVA: 0x00362160 File Offset: 0x00360360
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishFlipperConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishFlipperConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFinishFlipperConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishFlipperConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IFlipperConditionStepFightVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008124 RID: 33060
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141E5 RID: 82405
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141E6 RID: 82406
			public static VerifyTableAction <1>__Verify;
		}
	}
}
