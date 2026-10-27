using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566A RID: 22122
	public static class INpcStandbySitVerify
	{
		// Token: 0x06024CD6 RID: 150742 RVA: 0x00513E40 File Offset: 0x00512040
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

		// Token: 0x02007BB4 RID: 31668
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401365C RID: 79452
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401365D RID: 79453
			public static VerifyTableAction <1>__Verify;
		}
	}
}
