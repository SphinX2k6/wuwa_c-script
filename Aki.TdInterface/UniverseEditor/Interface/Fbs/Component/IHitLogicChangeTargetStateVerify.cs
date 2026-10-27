using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A0 RID: 21408
	public static class IHitLogicChangeTargetStateVerify
	{
		// Token: 0x06023109 RID: 143625 RVA: 0x004DACC0 File Offset: 0x004D8EC0
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

		// Token: 0x02007B58 RID: 31576
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135AC RID: 79276
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135AD RID: 79277
			public static VerifyTableAction <1>__Verify;
		}
	}
}
