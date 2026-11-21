using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200464B RID: 17995
	public static class ITrackCustomBoardOnBtLogicNodeVerify
	{
		// Token: 0x0601A5DB RID: 107995 RVA: 0x003C0D94 File Offset: 0x003BEF94
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

		// Token: 0x020081B8 RID: 33208
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014341 RID: 82753
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014342 RID: 82754
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014343 RID: 82755
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014344 RID: 82756
			public static VerifyTableAction <3>__Verify;
		}
	}
}
