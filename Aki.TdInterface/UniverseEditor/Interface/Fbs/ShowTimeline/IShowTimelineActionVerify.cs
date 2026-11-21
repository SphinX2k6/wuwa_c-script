using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FA5 RID: 16293
	public static class IShowTimelineActionVerify
	{
		// Token: 0x06016368 RID: 90984 RVA: 0x0032F1C0 File Offset: 0x0032D3C0
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

		// Token: 0x020080D0 RID: 32976
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014151 RID: 82257
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014152 RID: 82258
			public static VerifyTableAction <1>__Verify;
		}
	}
}
