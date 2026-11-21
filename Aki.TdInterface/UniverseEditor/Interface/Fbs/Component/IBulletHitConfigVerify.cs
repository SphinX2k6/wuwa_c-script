using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005474 RID: 21620
	public static class IBulletHitConfigVerify
	{
		// Token: 0x06021F74 RID: 139124 RVA: 0x004AE764 File Offset: 0x004AC964
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

		// Token: 0x020082ED RID: 33517
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144ED RID: 83181
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040144EE RID: 83182
			public static VerifyTableAction <1>__Verify;
		}
	}
}
