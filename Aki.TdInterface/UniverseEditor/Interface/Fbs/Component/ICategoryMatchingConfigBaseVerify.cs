using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005498 RID: 21656
	public static class ICategoryMatchingConfigBaseVerify
	{
		// Token: 0x0602213A RID: 139578 RVA: 0x004B2964 File Offset: 0x004B0B64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingConfigBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingConfigBaseVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICategoryMatchingConfigBaseVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICategoryMatchingConfigBaseVerify.<>O.<1>__Verify = new VerifyTableAction(ICategoryMatchingAnimationBaseVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICategoryMatchingConfigBaseVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ICategoryMatchingConfigBaseVerify.<>O.<2>__Verify = new VerifyTableAction(ICategoryMatchingSucceedBaseVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020082F8 RID: 33528
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144FE RID: 83198
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144FF RID: 83199
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014500 RID: 83200
			public static VerifyTableAction <2>__Verify;
		}
	}
}
