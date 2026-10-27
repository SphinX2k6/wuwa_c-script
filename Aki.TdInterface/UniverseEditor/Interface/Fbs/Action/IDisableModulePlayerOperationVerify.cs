using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065EA RID: 26090
	public static class IDisableModulePlayerOperationVerify
	{
		// Token: 0x0602D466 RID: 185446 RVA: 0x00634940 File Offset: 0x00632B40
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDisableModulePlayerOperationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDisableModulePlayerOperationVerify.<>O.<0>__Verify = new VerifyUnionAction(TMoveOperationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IDisableModulePlayerOperationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDisableModulePlayerOperationVerify.<>O.<1>__Verify = new VerifyUnionAction(TSkillOperationVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short typeIdVOffset3 = 14;
						short valueVOffset3 = 16;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IDisableModulePlayerOperationVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDisableModulePlayerOperationVerify.<>O.<2>__Verify = new VerifyUnionAction(TCameraOperationVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							short typeIdVOffset4 = 18;
							short valueVOffset4 = 20;
							VerifyUnionAction verifyAction4;
							if ((verifyAction4 = IDisableModulePlayerOperationVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IDisableModulePlayerOperationVerify.<>O.<3>__Verify = new VerifyUnionAction(TUiOperationVerify.Verify));
							}
							if (verifier.VerifyUnion(tablePos, typeIdVOffset4, valueVOffset4, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								short typeIdVOffset5 = 22;
								short valueVOffset5 = 24;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IDisableModulePlayerOperationVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IDisableModulePlayerOperationVerify.<>O.<4>__Verify = new VerifyUnionAction(TSceneInteractionOperationVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset5, valueVOffset5, verifyAction5, false))
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

		// Token: 0x02007D42 RID: 32066
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138B7 RID: 80055
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040138B8 RID: 80056
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040138B9 RID: 80057
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x040138BA RID: 80058
			public static VerifyUnionAction <3>__Verify;

			// Token: 0x040138BB RID: 80059
			public static VerifyUnionAction <4>__Verify;
		}
	}
}
