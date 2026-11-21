using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0B RID: 23563
	public static class INpcStandbySitVerify
	{
		// Token: 0x06026F0F RID: 159503 RVA: 0x005549DC File Offset: 0x00552BDC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcStandbySitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcStandbySitVerify.<>O.<0>__Verify = new VerifyTableAction(INpcLookAtConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcStandbySitVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INpcStandbySitVerify.<>O.<1>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008416 RID: 33814
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146EB RID: 83691
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146EC RID: 83692
			public static VerifyTableAction <1>__Verify;
		}
	}
}
