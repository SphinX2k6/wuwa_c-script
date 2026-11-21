using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F25 RID: 28453
	public static class IGetItemVerify
	{
		// Token: 0x060313E0 RID: 201696 RVA: 0x006AC0D8 File Offset: 0x006AA2D8
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

		// Token: 0x020085FB RID: 34299
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B7 RID: 84407
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149B8 RID: 84408
			public static VerifyTableAction <1>__Verify;
		}
	}
}
