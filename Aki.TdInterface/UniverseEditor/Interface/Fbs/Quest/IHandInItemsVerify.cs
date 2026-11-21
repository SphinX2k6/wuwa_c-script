using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CD RID: 17101
	public static class IHandInItemsVerify
	{
		// Token: 0x06017FE0 RID: 98272 RVA: 0x0036CB8C File Offset: 0x0036AD8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHandInItemsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHandInItemsVerify.<>O.<0>__Verify = new VerifyTableAction(IHandInItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHandInItemsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IHandInItemsVerify.<>O.<1>__Verify = new VerifyTableAction(IHandInGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008139 RID: 33081
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401420B RID: 82443
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401420C RID: 82444
			public static VerifyTableAction <1>__Verify;
		}
	}
}
