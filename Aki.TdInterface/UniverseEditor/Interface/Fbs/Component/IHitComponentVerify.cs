using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590E RID: 22798
	public static class IHitComponentVerify
	{
		// Token: 0x060250DD RID: 151773 RVA: 0x00515D28 File Offset: 0x00513F28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHitComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHitComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHitComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IHitComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IHitComponentVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IHitComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IHitComponentVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IHitComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IAimPartVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false))
							{
								short offsetId4 = 16;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IHitComponentVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IHitComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IBulletHitConfigVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction5, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020083B3 RID: 33715
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014628 RID: 83496
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014629 RID: 83497
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401462A RID: 83498
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401462B RID: 83499
			public static VerifyTableAction <3>__Verify;
		}
	}
}
