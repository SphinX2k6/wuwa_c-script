using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004198 RID: 16792
	public static class ITakePhoto2TargetEntityTypeVerify
	{
		// Token: 0x06018B66 RID: 101222 RVA: 0x0038F048 File Offset: 0x0038D248
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

		// Token: 0x0200795F RID: 31071
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132B6 RID: 78518
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132B7 RID: 78519
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132B8 RID: 78520
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040132B9 RID: 78521
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040132BA RID: 78522
			public static VerifyTableAction <4>__Verify;
		}
	}
}
