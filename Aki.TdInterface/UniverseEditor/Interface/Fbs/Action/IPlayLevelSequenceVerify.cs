using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D25 RID: 27941
	public static class IPlayLevelSequenceVerify
	{
		// Token: 0x06031489 RID: 201865 RVA: 0x006AF148 File Offset: 0x006AD348
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayLevelSequenceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayLevelSequenceVerify.<>O.<0>__Verify = new VerifyTableAction(ILoopRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short typeIdVOffset = 16;
					short valueVOffset = 18;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IPlayLevelSequenceVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlayLevelSequenceVerify.<>O.<1>__Verify = new VerifyUnionAction(TLevelSequenceTransitionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 20;
						short valueVOffset2 = 22;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IPlayLevelSequenceVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IPlayLevelSequenceVerify.<>O.<1>__Verify = new VerifyUnionAction(TLevelSequenceTransitionVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
						{
							short offsetId2 = 26;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IPlayLevelSequenceVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IPlayLevelSequenceVerify.<>O.<2>__Verify = new VerifyTableAction(IEaseDataVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId2, verifyAction4, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
							{
								short offsetId3 = 32;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IPlayLevelSequenceVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IPlayLevelSequenceVerify.<>O.<3>__Verify = new VerifyTableAction(IFloatingSubtitleLanguageDiffVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId3, verifyAction5, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false))
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

		// Token: 0x02007DF7 RID: 32247
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139AB RID: 80299
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139AC RID: 80300
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040139AD RID: 80301
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040139AE RID: 80302
			public static VerifyTableAction <3>__Verify;
		}
	}
}
