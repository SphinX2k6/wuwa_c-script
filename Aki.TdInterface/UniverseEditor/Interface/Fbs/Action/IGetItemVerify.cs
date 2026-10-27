using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006884 RID: 26756
	public static class IGetItemVerify
	{
		// Token: 0x0602EAA6 RID: 191142 RVA: 0x0065D058 File Offset: 0x0065B258
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGetItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGetItemVerify.<>O.<0>__Verify = new VerifyTableAction(IItemDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGetItemVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGetItemVerify.<>O.<1>__Verify = new VerifyTableAction(IItemGetUiConfigSpecialQuestVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D82 RID: 32130
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013908 RID: 80136
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013909 RID: 80137
			public static VerifyTableAction <1>__Verify;
		}
	}
}
