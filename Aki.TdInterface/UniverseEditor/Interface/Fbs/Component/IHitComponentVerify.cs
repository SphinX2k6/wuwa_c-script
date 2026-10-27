using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005388 RID: 21384
	public static class IHitComponentVerify
	{
		// Token: 0x06023029 RID: 143401 RVA: 0x004D8E54 File Offset: 0x004D7054
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

		// Token: 0x02007B54 RID: 31572
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135A3 RID: 79267
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040135A4 RID: 79268
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040135A5 RID: 79269
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040135A6 RID: 79270
			public static VerifyTableAction <3>__Verify;
		}
	}
}
