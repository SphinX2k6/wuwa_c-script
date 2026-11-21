using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C7 RID: 17863
	public static class ITakePhoto2ConditionVerify
	{
		// Token: 0x0601A14C RID: 106828 RVA: 0x003B7734 File Offset: 0x003B5934
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhoto2ConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2ConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITakePhoto2ConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITakePhoto2ConditionVerify.<>O.<1>__Verify = new VerifyTableAction(ITakePhoto2TimeConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITakePhoto2ConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITakePhoto2ConditionVerify.<>O.<2>__Verify = new VerifyTableAction(ITakePhoto2PosConditionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITakePhoto2ConditionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITakePhoto2ConditionVerify.<>O.<3>__Verify = new VerifyTableAction(ITakePhoto2CameraFovConditionVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 18;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITakePhoto2ConditionVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITakePhoto2ConditionVerify.<>O.<4>__Verify = new VerifyTableAction(ITakePhoto2SequenceConditionVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyVectorOfData(tablePos, 24, 1UL, false))
								{
									short offsetId6 = 28;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITakePhoto2ConditionVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITakePhoto2ConditionVerify.<>O.<5>__Verify = new VerifyTableAction(ITakePhoto2BeforeYourEyesModeVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
									{
										return verifier.VerifyTableEnd(tablePos);
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020081A3 RID: 33187
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401430C RID: 82700
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401430D RID: 82701
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401430E RID: 82702
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401430F RID: 82703
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014310 RID: 82704
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04014311 RID: 82705
			public static VerifyTableAction <5>__Verify;
		}
	}
}
