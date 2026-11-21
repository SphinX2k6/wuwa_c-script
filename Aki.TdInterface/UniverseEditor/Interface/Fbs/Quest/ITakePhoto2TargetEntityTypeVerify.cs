using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F1 RID: 17905
	public static class ITakePhoto2TargetEntityTypeVerify
	{
		// Token: 0x0601A2BC RID: 107196 RVA: 0x003BA49C File Offset: 0x003B869C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhoto2TargetEntityTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2TargetEntityTypeVerify.<>O.<0>__Verify = new VerifyTableAction(ITakePhoto2TargetCameraDistanceConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITakePhoto2TargetEntityTypeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITakePhoto2TargetEntityTypeVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityCategoryVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITakePhoto2TargetEntityTypeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITakePhoto2TargetEntityTypeVerify.<>O.<2>__Verify = new VerifyTableAction(ITakePhoto2TargetPosByRangeConditionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITakePhoto2TargetEntityTypeVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITakePhoto2TargetEntityTypeVerify.<>O.<3>__Verify = new VerifyTableAction(ITakePhoto2TargetPlayMontageConditionVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 16;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITakePhoto2TargetEntityTypeVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITakePhoto2TargetEntityTypeVerify.<>O.<4>__Verify = new VerifyTableAction(ITakePhoto2TargetAnsTagConditionVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
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

		// Token: 0x020081A8 RID: 33192
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401431C RID: 82716
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401431D RID: 82717
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401431E RID: 82718
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401431F RID: 82719
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014320 RID: 82720
			public static VerifyTableAction <4>__Verify;
		}
	}
}
