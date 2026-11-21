using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045CA RID: 17866
	public static class ITakePhoto2EntityTargetVerify
	{
		// Token: 0x0601A17E RID: 106878 RVA: 0x003B8020 File Offset: 0x003B6220
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

		// Token: 0x020081A4 RID: 33188
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014312 RID: 82706
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014313 RID: 82707
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014314 RID: 82708
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014315 RID: 82709
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014316 RID: 82710
			public static VerifyTableAction <4>__Verify;
		}
	}
}
