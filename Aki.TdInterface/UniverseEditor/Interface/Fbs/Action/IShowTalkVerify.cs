using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070ED RID: 28909
	public static class IShowTalkVerify
	{
		// Token: 0x060333DC RID: 209884 RVA: 0x006E8B68 File Offset: 0x006E6D68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTalkVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTalkVerify.<>O.<0>__Verify = new VerifyTableAction(IShowTalkOutlineVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 12, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IShowTalkVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IShowTalkVerify.<>O.<1>__Verify = new VerifyTableAction(IShowTalkFrameEventVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IShowTalkVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IShowTalkVerify.<>O.<2>__Verify = new VerifyTableAction(IShowTalk_TalkSequenceRowVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyVectorOfStrings(tablePos, 18, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IShowTalkVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IShowTalkVerify.<>O.<3>__Verify = new VerifyTableAction(Record_Int_ITalkSequenceTransitionsVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								short offsetId5 = 24;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IShowTalkVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IShowTalkVerify.<>O.<4>__Verify = new VerifyTableAction(ISetBlendAnimVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
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

		// Token: 0x02007E5C RID: 32348
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A33 RID: 80435
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A34 RID: 80436
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013A35 RID: 80437
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013A36 RID: 80438
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013A37 RID: 80439
			public static VerifyTableAction <4>__Verify;
		}
	}
}
