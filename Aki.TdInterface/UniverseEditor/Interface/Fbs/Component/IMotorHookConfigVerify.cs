using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B9 RID: 21945
	public static class IMotorHookConfigVerify
	{
		// Token: 0x060245AE RID: 148910 RVA: 0x00504CA0 File Offset: 0x00502EA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorHookConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorHookConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFaceToTargetMotorInteractConstraintVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMotorHookConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMotorHookConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IMotorHookEndDirVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMotorHookConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IMotorHookConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IMotorHookAccelerationVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							short typeIdVOffset = 14;
							short valueVOffset = 16;
							VerifyUnionAction verifyAction4;
							if ((verifyAction4 = IMotorHookConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IMotorHookConfigVerify.<>O.<3>__Verify = new VerifyUnionAction(THookLockScreenDetectTypeVerify.Verify));
							}
							if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction4, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
							{
								short offsetId4 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IMotorHookConfigVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IMotorHookConfigVerify.<>O.<4>__Verify = new VerifyTableAction(IMotorHookPerformanceConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
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

		// Token: 0x02007B98 RID: 31640
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013627 RID: 79399
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013628 RID: 79400
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013629 RID: 79401
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401362A RID: 79402
			public static VerifyUnionAction <3>__Verify;

			// Token: 0x0401362B RID: 79403
			public static VerifyTableAction <4>__Verify;
		}
	}
}
