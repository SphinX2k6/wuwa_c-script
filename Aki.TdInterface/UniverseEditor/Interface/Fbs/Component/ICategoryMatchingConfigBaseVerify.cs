using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F69 RID: 20329
	public static class ICategoryMatchingConfigBaseVerify
	{
		// Token: 0x060203E8 RID: 132072 RVA: 0x0047C974 File Offset: 0x0047AB74
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

		// Token: 0x02007AA2 RID: 31394
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013488 RID: 78984
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013489 RID: 78985
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401348A RID: 78986
			public static VerifyTableAction <2>__Verify;
		}
	}
}
