using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF0 RID: 20464
	public static class IConditionBubbleDataVerify
	{
		// Token: 0x06020B4A RID: 133962 RVA: 0x0048C22C File Offset: 0x0048A42C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionBubbleDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionBubbleDataVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConditionBubbleDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionBubbleDataVerify.<>O.<1>__Verify = new VerifyTableAction(IBubbleDataVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007ABD RID: 31421
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134AE RID: 79022
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134AF RID: 79023
			public static VerifyTableAction <1>__Verify;
		}
	}
}
