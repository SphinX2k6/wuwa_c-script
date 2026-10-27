using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F42 RID: 20290
	public static class IBulletHitConfigVerify
	{
		// Token: 0x06020204 RID: 131588 RVA: 0x004783D0 File Offset: 0x004765D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBulletHitConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBulletHitConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBulletHitConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBulletHitConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBulletHitConfigVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IBulletHitConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007A96 RID: 31382
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013476 RID: 78966
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013477 RID: 78967
			public static VerifyTableAction <1>__Verify;
		}
	}
}
