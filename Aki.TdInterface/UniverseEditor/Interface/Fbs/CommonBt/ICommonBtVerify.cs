using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E1 RID: 25825
	public static class ICommonBtVerify
	{
		// Token: 0x0602BE97 RID: 179863 RVA: 0x005F880C File Offset: 0x005F6A0C
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

		// Token: 0x0200852B RID: 34091
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401488F RID: 84111
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014890 RID: 84112
			public static VerifyTableAction <1>__Verify;
		}
	}
}
