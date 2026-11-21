using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007233 RID: 29235
	public static class IMontageDataRenderVerify
	{
		// Token: 0x06032E4F RID: 208463 RVA: 0x006DF1B8 File Offset: 0x006DD3B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMontageDataRenderVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMontageDataRenderVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMontageDataRenderVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMontageDataRenderVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageParamVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMontageDataRenderVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IMontageDataRenderVerify.<>O.<1>__Verify = new VerifyTableAction(IActorFxEmotePlayVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008636 RID: 34358
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A0A RID: 84490
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A0B RID: 84491
			public static VerifyTableAction <1>__Verify;
		}
	}
}
