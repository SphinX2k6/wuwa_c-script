using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200434B RID: 17227
	public static class IListenToEventVerify
	{
		// Token: 0x06018408 RID: 99336 RVA: 0x00374C04 File Offset: 0x00372E04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IListenToEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IListenToEventVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IListenToEventVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IListenToEventVerify.<>O.<1>__Verify = new VerifyUnionAction(TCommonEventTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200814A RID: 33098
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014223 RID: 82467
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014224 RID: 82468
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
