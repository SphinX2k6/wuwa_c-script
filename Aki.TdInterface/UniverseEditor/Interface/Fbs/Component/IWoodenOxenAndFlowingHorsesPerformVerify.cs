using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8E RID: 23438
	public static class IWoodenOxenAndFlowingHorsesPerformVerify
	{
		// Token: 0x06028208 RID: 164360 RVA: 0x00583E8C File Offset: 0x0058208C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWoodenOxenAndFlowingHorsesPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWoodenOxenAndFlowingHorsesPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IWoodenOxenAndFlowingHorsesPerformConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWoodenOxenAndFlowingHorsesPerformVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IWoodenOxenAndFlowingHorsesPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IWoodenOxenAndFlowingHorsesPerformConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IWoodenOxenAndFlowingHorsesPerformVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IWoodenOxenAndFlowingHorsesPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IWoodenOxenAndFlowingHorsesPerformConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IWoodenOxenAndFlowingHorsesPerformVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (IWoodenOxenAndFlowingHorsesPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IWoodenOxenAndFlowingHorsesPerformConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C82 RID: 31874
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137AC RID: 79788
			public static VerifyTableAction <0>__Verify;
		}
	}
}
