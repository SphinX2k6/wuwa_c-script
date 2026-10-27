using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005493 RID: 21651
	public static class IItemFoundationVerify
	{
		// Token: 0x06023A25 RID: 145957 RVA: 0x004ED418 File Offset: 0x004EB618
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IItemFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(IAdsortTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IItemFoundationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IItemFoundationVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityMatchVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IItemFoundationVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IItemFoundationVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityMatchVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IItemFoundationVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IItemFoundationVerify.<>O.<2>__Verify = new VerifyTableAction(IItemChangeAdsorbateStateVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007B73 RID: 31603
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135E4 RID: 79332
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135E5 RID: 79333
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040135E6 RID: 79334
			public static VerifyTableAction <2>__Verify;
		}
	}
}
