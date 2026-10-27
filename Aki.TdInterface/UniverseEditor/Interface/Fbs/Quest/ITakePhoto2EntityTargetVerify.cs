using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004180 RID: 16768
	public static class ITakePhoto2EntityTargetVerify
	{
		// Token: 0x06018A78 RID: 100984 RVA: 0x0038D278 File Offset: 0x0038B478
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhoto2EntityTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2EntityTargetVerify.<>O.<0>__Verify = new VerifyTableAction(ITakePhoto2TargetCameraDistanceConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITakePhoto2EntityTargetVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITakePhoto2EntityTargetVerify.<>O.<1>__Verify = new VerifyTableAction(ITakePhoto2TargetPosByRangeConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITakePhoto2EntityTargetVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITakePhoto2EntityTargetVerify.<>O.<2>__Verify = new VerifyTableAction(ITakePhoto2TargetPlayMontageConditionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITakePhoto2EntityTargetVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITakePhoto2EntityTargetVerify.<>O.<3>__Verify = new VerifyTableAction(ITakePhoto2TargetAnsTagConditionVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 18;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITakePhoto2EntityTargetVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITakePhoto2EntityTargetVerify.<>O.<4>__Verify = new VerifyTableAction(ITakePhoto2TargetPartConditionVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200795B RID: 31067
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132AC RID: 78508
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132AD RID: 78509
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132AE RID: 78510
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040132AF RID: 78511
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040132B0 RID: 78512
			public static VerifyTableAction <4>__Verify;
		}
	}
}
