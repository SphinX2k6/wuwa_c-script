using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006148 RID: 24904
	public static class IAdjustDialogCameraVerify
	{
		// Token: 0x0602AB22 RID: 174882 RVA: 0x005E1F34 File Offset: 0x005E0134
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdjustDialogCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustDialogCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdjustDialogCameraVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAdjustDialogCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAdjustDialogCameraVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IAdjustDialogCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IAdjustDialogCameraVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IAdjustDialogCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
							{
								short typeIdVOffset = 38;
								short valueVOffset = 40;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IAdjustDialogCameraVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IAdjustDialogCameraVerify.<>O.<2>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 46, false) && verifier.VerifyField(tablePos, 48, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 50, 4UL, 4UL, false))
								{
									short offsetId5 = 52;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IAdjustDialogCameraVerify.<>O.<1>__Verify) == null)
									{
										verifyAction6 = (IAdjustDialogCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false) && verifier.VerifyField(tablePos, 54, 1UL, 1UL, false))
									{
										return verifier.VerifyTableEnd(tablePos);
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007CE3 RID: 31971
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013824 RID: 79908
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013825 RID: 79909
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013826 RID: 79910
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
