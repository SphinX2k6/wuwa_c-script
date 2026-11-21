using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A4 RID: 24996
	public static class IWoodenOxenAndFlowingHorsesPerformVerify
	{
		// Token: 0x0602A7CC RID: 174028 RVA: 0x005CB91C File Offset: 0x005C9B1C
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

		// Token: 0x020084F3 RID: 34035
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014852 RID: 84050
			public static VerifyTableAction <0>__Verify;
		}
	}
}
