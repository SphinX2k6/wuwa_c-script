using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4F RID: 23119
	public static class ILevelAIComponentVerify
	{
		// Token: 0x06025D13 RID: 154899 RVA: 0x0052F14C File Offset: 0x0052D34C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelAIComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelAIComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelAIStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelAIComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelAIComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ICommonBtOverrideVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083DA RID: 33754
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401467C RID: 83580
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401467D RID: 83581
			public static VerifyTableAction <1>__Verify;
		}
	}
}
