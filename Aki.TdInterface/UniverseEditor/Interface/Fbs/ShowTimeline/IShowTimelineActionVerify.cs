using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B9D RID: 15261
	public static class IShowTimelineActionVerify
	{
		// Token: 0x06014E9E RID: 85662 RVA: 0x00308C28 File Offset: 0x00306E28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IShowTimelineActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTimelineActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TShowTimelineActionOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IShowTimelineActionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IShowTimelineActionVerify.<>O.<1>__Verify = new VerifyTableAction(IShowTimelineActionDisplayConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200788D RID: 30861
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130F6 RID: 78070
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040130F7 RID: 78071
			public static VerifyTableAction <1>__Verify;
		}
	}
}
