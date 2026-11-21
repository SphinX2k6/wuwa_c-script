using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005495 RID: 21653
	public static class ICategoryMatchingConfigVerify
	{
		// Token: 0x06022120 RID: 139552 RVA: 0x004B2520 File Offset: 0x004B0720
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

		// Token: 0x020082F7 RID: 33527
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144FA RID: 83194
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144FB RID: 83195
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040144FC RID: 83196
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040144FD RID: 83197
			public static VerifyTableAction <3>__Verify;
		}
	}
}
