using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044CE RID: 17614
	public static class IRecallEntityConfigVerify
	{
		// Token: 0x0601974B RID: 104267 RVA: 0x003A1B20 File Offset: 0x0039FD20
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

		// Token: 0x0200818F RID: 33167
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142C9 RID: 82633
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040142CA RID: 82634
			public static VerifyTableAction <1>__Verify;
		}
	}
}
