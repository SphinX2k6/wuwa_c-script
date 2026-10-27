using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A67 RID: 27239
	public static class ILoopSeasonChangeVerify
	{
		// Token: 0x0602FB51 RID: 195409 RVA: 0x0067E0F8 File Offset: 0x0067C2F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILoopSeasonChangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILoopSeasonChangeVerify.<>O.<0>__Verify = new VerifyTableAction(ISeasonLoopConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILoopSeasonChangeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ILoopSeasonChangeVerify.<>O.<0>__Verify = new VerifyTableAction(ISeasonLoopConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILoopSeasonChangeVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ILoopSeasonChangeVerify.<>O.<0>__Verify = new VerifyTableAction(ISeasonLoopConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ILoopSeasonChangeVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (ILoopSeasonChangeVerify.<>O.<0>__Verify = new VerifyTableAction(ISeasonLoopConfigVerify.Verify));
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

		// Token: 0x02007DA1 RID: 32161
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013939 RID: 80185
			public static VerifyTableAction <0>__Verify;
		}
	}
}
