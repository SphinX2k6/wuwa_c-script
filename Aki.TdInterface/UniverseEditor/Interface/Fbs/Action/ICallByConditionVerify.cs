using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E2 RID: 26850
	public static class ICallByConditionVerify
	{
		// Token: 0x0602DF59 RID: 188249 RVA: 0x00648280 File Offset: 0x00646480
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICallByConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICallByConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICallByConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICallByConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICallByConditionVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ICallByConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008571 RID: 34161
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014905 RID: 84229
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014906 RID: 84230
			public static VerifyTableAction <1>__Verify;
		}
	}
}
