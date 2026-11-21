using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554F RID: 21839
	public static class IConditionBubbleDataVerify
	{
		// Token: 0x06022A6A RID: 141930 RVA: 0x004C5C7C File Offset: 0x004C3E7C
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

		// Token: 0x02008317 RID: 33559
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401452C RID: 83244
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401452D RID: 83245
			public static VerifyTableAction <1>__Verify;
		}
	}
}
