using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200446C RID: 17516
	public static class IDartCompetitorBubblesVerify
	{
		// Token: 0x0601A1B5 RID: 106933 RVA: 0x003BADF0 File Offset: 0x003B8FF0
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

		// Token: 0x020079A0 RID: 31136
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013325 RID: 78629
			public static VerifyTableAction <0>__Verify;
		}
	}
}
