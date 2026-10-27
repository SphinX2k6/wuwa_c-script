using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005E9E RID: 24222
	public static class ICommonBtVerify
	{
		// Token: 0x060297EF RID: 169967 RVA: 0x005AF868 File Offset: 0x005ADA68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 18, false))
			{
				short offsetId = 20;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtTreeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 22;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICommonBtVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICommonBtVerify.<>O.<1>__Verify = new VerifyTableAction(ICommonBtPlaceholderVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 28, false) && verifier.VerifyString(tablePos, 30, false) && verifier.VerifyString(tablePos, 32, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CBA RID: 31930
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E9 RID: 79849
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137EA RID: 79850
			public static VerifyTableAction <1>__Verify;
		}
	}
}
