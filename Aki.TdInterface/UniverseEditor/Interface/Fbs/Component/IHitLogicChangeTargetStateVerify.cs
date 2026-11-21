using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005926 RID: 22822
	public static class IHitLogicChangeTargetStateVerify
	{
		// Token: 0x060251BD RID: 151997 RVA: 0x00517B94 File Offset: 0x00515D94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHitLogicChangeTargetStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHitLogicChangeTargetStateVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionHitConfigWithBulletVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHitLogicChangeTargetStateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IHitLogicChangeTargetStateVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionHitConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083B7 RID: 33719
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014631 RID: 83505
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014632 RID: 83506
			public static VerifyTableAction <1>__Verify;
		}
	}
}
