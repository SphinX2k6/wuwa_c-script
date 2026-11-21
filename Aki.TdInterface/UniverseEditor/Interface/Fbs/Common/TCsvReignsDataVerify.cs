using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064BD RID: 25789
	public static class TCsvReignsDataVerify
	{
		// Token: 0x0602BD9B RID: 179611 RVA: 0x005F6ABC File Offset: 0x005F4CBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvReignsDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvReignsDataVerify.<>O.<0>__Verify = new VerifyTableAction(IReignsPropertyConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = TCsvReignsDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (TCsvReignsDataVerify.<>O.<1>__Verify = new VerifyTableAction(IReignsEndingVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200852A RID: 34090
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401488D RID: 84109
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401488E RID: 84110
			public static VerifyTableAction <1>__Verify;
		}
	}
}
