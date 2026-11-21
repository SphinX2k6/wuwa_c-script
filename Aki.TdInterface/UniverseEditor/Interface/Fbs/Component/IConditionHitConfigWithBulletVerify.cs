using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005555 RID: 21845
	public static class IConditionHitConfigWithBulletVerify
	{
		// Token: 0x06022AA6 RID: 141990 RVA: 0x004C6550 File Offset: 0x004C4750
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionHitConfigWithBulletVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionHitConfigWithBulletVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IConditionHitConfigWithBulletVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionHitConfigWithBulletVerify.<>O.<1>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008319 RID: 33561
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401452F RID: 83247
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014530 RID: 83248
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
