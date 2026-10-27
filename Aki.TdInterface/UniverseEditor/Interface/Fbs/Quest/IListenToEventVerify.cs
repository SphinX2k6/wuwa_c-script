using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F0D RID: 16141
	public static class IListenToEventVerify
	{
		// Token: 0x06016DB1 RID: 93617 RVA: 0x0034BA38 File Offset: 0x00349C38
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

		// Token: 0x02007904 RID: 30980
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131C4 RID: 78276
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131C5 RID: 78277
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
