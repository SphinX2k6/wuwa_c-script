using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006467 RID: 25703
	public static class ICommonBtOverrideVerify
	{
		// Token: 0x0602C7BF RID: 182207 RVA: 0x00619AE0 File Offset: 0x00617CE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtOverrideVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtOverrideVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtPlaceholderVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICommonBtOverrideVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICommonBtOverrideVerify.<>O.<1>__Verify = new VerifyTableAction(ICommonBtClientOverrideDataVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D2C RID: 32044
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401389A RID: 80026
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401389B RID: 80027
			public static VerifyTableAction <1>__Verify;
		}
	}
}
