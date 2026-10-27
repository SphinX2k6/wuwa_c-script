using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFC RID: 27388
	public static class IMontageDataRenderVerify
	{
		// Token: 0x0603007B RID: 196731 RVA: 0x00687B00 File Offset: 0x00685D00
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

		// Token: 0x02007DAF RID: 32175
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401394C RID: 80204
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401394D RID: 80205
			public static VerifyTableAction <1>__Verify;
		}
	}
}
