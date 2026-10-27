using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C9 RID: 21705
	public static class ILevelAIComponentVerify
	{
		// Token: 0x06023C5B RID: 146523 RVA: 0x004F20D8 File Offset: 0x004F02D8
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

		// Token: 0x02007B7B RID: 31611
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135F6 RID: 79350
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135F7 RID: 79351
			public static VerifyTableAction <1>__Verify;
		}
	}
}
