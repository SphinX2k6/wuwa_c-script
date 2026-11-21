using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D4 RID: 18644
	public static class IDartCompetitorBubblesVerify
	{
		// Token: 0x0601B986 RID: 113030 RVA: 0x003E6FFC File Offset: 0x003E51FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDartCompetitorBubblesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDartCompetitorBubblesVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDartCompetitorBubblesVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IDartCompetitorBubblesVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDartCompetitorBubblesVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IDartCompetitorBubblesVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 10;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IDartCompetitorBubblesVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IDartCompetitorBubblesVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
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

		// Token: 0x020081E9 RID: 33257
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401438C RID: 82828
			public static VerifyTableAction <0>__Verify;
		}
	}
}
