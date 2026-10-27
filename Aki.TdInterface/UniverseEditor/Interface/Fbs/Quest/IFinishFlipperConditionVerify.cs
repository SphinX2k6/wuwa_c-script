using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E38 RID: 15928
	public static class IFinishFlipperConditionVerify
	{
		// Token: 0x06016552 RID: 91474 RVA: 0x00339568 File Offset: 0x00337768
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

		// Token: 0x020078DE RID: 30942
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013187 RID: 78215
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013188 RID: 78216
			public static VerifyTableAction <1>__Verify;
		}
	}
}
