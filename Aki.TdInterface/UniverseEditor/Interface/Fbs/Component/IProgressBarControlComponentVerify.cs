using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A1 RID: 22433
	public static class IProgressBarControlComponentVerify
	{
		// Token: 0x06025A2B RID: 154155 RVA: 0x005310C0 File Offset: 0x0052F2C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IProgressBarControlComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProgressBarControlComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IProgressBarControlComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IProgressBarControlComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IProgressBarControlComponentVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IProgressBarControlComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IProgressBarControlComponentVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IProgressBarControlComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IAimPartVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
							{
								short typeIdVOffset2 = 16;
								short valueVOffset2 = 18;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IProgressBarControlComponentVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IProgressBarControlComponentVerify.<>O.<3>__Verify = new VerifyUnionAction(TProgressBarControlVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction5, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
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

		// Token: 0x02007BE9 RID: 31721
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136AF RID: 79535
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040136B0 RID: 79536
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040136B1 RID: 79537
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040136B2 RID: 79538
			public static VerifyUnionAction <3>__Verify;
		}
	}
}
