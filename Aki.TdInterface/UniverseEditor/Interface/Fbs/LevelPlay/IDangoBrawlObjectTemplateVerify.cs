using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004463 RID: 17507
	public static class IDangoBrawlObjectTemplateVerify
	{
		// Token: 0x0601A171 RID: 106865 RVA: 0x003BA520 File Offset: 0x003B8720
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDangoBrawlObjectTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDangoBrawlObjectTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDangoBrawlObjectTemplateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDangoBrawlObjectTemplateVerify.<>O.<1>__Verify = new VerifyTableAction(IIntVector2Verify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDangoBrawlObjectTemplateVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IDangoBrawlObjectTemplateVerify.<>O.<1>__Verify = new VerifyTableAction(IIntVector2Verify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200799F RID: 31135
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013323 RID: 78627
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013324 RID: 78628
			public static VerifyTableAction <1>__Verify;
		}
	}
}
