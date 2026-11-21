using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007230 RID: 29232
	public static class IMontageDataVerify
	{
		// Token: 0x06032E0F RID: 208399 RVA: 0x006DE7B0 File Offset: 0x006DC9B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
			{
				short offsetId = 22;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMontageDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMontageDataVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMontageDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMontageDataVerify.<>O.<1>__Verify = new VerifyTableAction(IActorFxEmotePlayVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 30, 2UL, 2UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008635 RID: 34357
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A08 RID: 84488
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A09 RID: 84489
			public static VerifyTableAction <1>__Verify;
		}
	}
}
