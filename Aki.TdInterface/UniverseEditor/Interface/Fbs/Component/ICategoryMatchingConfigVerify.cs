using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F66 RID: 20326
	public static class ICategoryMatchingConfigVerify
	{
		// Token: 0x060203CE RID: 132046 RVA: 0x0047C530 File Offset: 0x0047A730
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICategoryMatchingConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICategoryMatchingConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ICategoryMatchingAnimationVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICategoryMatchingConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ICategoryMatchingConfigVerify.<>O.<2>__Verify = new VerifyTableAction(ICategoryMatchingSucceedVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 10;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ICategoryMatchingConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ICategoryMatchingConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IItemLockingConfigVerify.Verify));
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

		// Token: 0x02007AA1 RID: 31393
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013484 RID: 78980
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013485 RID: 78981
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013486 RID: 78982
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013487 RID: 78983
			public static VerifyTableAction <3>__Verify;
		}
	}
}
