using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200408D RID: 16525
	public static class IRecallEntityConfigVerify
	{
		// Token: 0x060180B2 RID: 98482 RVA: 0x00377CE8 File Offset: 0x00375EE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRecallEntityConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRecallEntityConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRecallEntityGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRecallEntityConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRecallEntityConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IRecallEntryVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007948 RID: 31048
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013266 RID: 78438
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013267 RID: 78439
			public static VerifyTableAction <1>__Verify;
		}
	}
}
