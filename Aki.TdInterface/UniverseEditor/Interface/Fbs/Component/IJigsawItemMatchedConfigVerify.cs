using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A37 RID: 23095
	public static class IJigsawItemMatchedConfigVerify
	{
		// Token: 0x06025C1D RID: 154653 RVA: 0x0052D180 File Offset: 0x0052B380
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IJigsawItemMatchedConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IJigsawItemMatchedConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPieceIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IJigsawItemMatchedConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IJigsawItemMatchedConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IJigsawItemMatchedConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IJigsawItemMatchedConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionActionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IJigsawItemMatchedConfigVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IJigsawItemMatchedConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020083D6 RID: 33750
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014675 RID: 83573
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014676 RID: 83574
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014677 RID: 83575
			public static VerifyTableAction <2>__Verify;
		}
	}
}
