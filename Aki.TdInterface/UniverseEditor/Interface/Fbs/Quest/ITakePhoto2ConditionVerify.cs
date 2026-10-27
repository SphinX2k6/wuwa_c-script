using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417D RID: 16765
	public static class ITakePhoto2ConditionVerify
	{
		// Token: 0x06018A46 RID: 100934 RVA: 0x0038C9E4 File Offset: 0x0038ABE4
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
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyVectorOfData(tablePos, 22, 1UL, false))
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

		// Token: 0x0200795A RID: 31066
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132A7 RID: 78503
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132A8 RID: 78504
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132A9 RID: 78505
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040132AA RID: 78506
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040132AB RID: 78507
			public static VerifyTableAction <4>__Verify;
		}
	}
}
