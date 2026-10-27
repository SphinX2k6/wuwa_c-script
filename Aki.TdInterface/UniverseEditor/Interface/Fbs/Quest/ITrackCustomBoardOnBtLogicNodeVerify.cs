using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F2 RID: 16882
	public static class ITrackCustomBoardOnBtLogicNodeVerify
	{
		// Token: 0x06018E81 RID: 102017 RVA: 0x00395834 File Offset: 0x00393A34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrackCustomBoardOnBtLogicNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackCustomBoardOnBtLogicNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFastReturnMapPosVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrackCustomBoardOnBtLogicNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrackCustomBoardOnBtLogicNodeVerify.<>O.<1>__Verify = new VerifyTableAction(ISheriffAnomalyProgressBoardConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITrackCustomBoardOnBtLogicNodeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITrackCustomBoardOnBtLogicNodeVerify.<>O.<2>__Verify = new VerifyTableAction(ISheriffMainBoardConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 10;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITrackCustomBoardOnBtLogicNodeVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITrackCustomBoardOnBtLogicNodeVerify.<>O.<3>__Verify = new VerifyTableAction(ISheriffClueDetailBoardConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200796F RID: 31087
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132DA RID: 78554
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132DB RID: 78555
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132DC RID: 78556
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040132DD RID: 78557
			public static VerifyTableAction <3>__Verify;
		}
	}
}
