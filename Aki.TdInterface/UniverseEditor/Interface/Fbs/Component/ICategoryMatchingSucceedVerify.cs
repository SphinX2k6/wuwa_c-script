using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F6F RID: 20335
	public static class ICategoryMatchingSucceedVerify
	{
		// Token: 0x0602044C RID: 132172 RVA: 0x0047D6FC File Offset: 0x0047B8FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingSucceedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingSucceedVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICategoryMatchingSucceedVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICategoryMatchingSucceedVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 18, false))
					{
						short offsetId3 = 20;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICategoryMatchingSucceedVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ICategoryMatchingSucceedVerify.<>O.<1>__Verify = new VerifyTableAction(IItemChangeAdsorbateStateVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AA4 RID: 31396
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401348C RID: 78988
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401348D RID: 78989
			public static VerifyTableAction <1>__Verify;
		}
	}
}
