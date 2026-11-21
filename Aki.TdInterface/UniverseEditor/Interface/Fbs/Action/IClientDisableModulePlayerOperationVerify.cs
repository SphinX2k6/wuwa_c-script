using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A04 RID: 27140
	public static class IClientDisableModulePlayerOperationVerify
	{
		// Token: 0x0602E90E RID: 190734 RVA: 0x00659E44 File Offset: 0x00658044
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientDisableModulePlayerOperationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientDisableModulePlayerOperationVerify.<>O.<0>__Verify = new VerifyUnionAction(TMoveOperationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IClientDisableModulePlayerOperationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IClientDisableModulePlayerOperationVerify.<>O.<1>__Verify = new VerifyUnionAction(TSkillOperationVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short typeIdVOffset3 = 14;
						short valueVOffset3 = 16;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IClientDisableModulePlayerOperationVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IClientDisableModulePlayerOperationVerify.<>O.<2>__Verify = new VerifyUnionAction(TCameraOperationVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							short typeIdVOffset4 = 18;
							short valueVOffset4 = 20;
							VerifyUnionAction verifyAction4;
							if ((verifyAction4 = IClientDisableModulePlayerOperationVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IClientDisableModulePlayerOperationVerify.<>O.<3>__Verify = new VerifyUnionAction(TUiOperationVerify.Verify));
							}
							if (verifier.VerifyUnion(tablePos, typeIdVOffset4, valueVOffset4, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								short typeIdVOffset5 = 22;
								short valueVOffset5 = 24;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IClientDisableModulePlayerOperationVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IClientDisableModulePlayerOperationVerify.<>O.<4>__Verify = new VerifyUnionAction(TSceneInteractionOperationVerify.Verify));
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

		// Token: 0x0200858D RID: 34189
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401492A RID: 84266
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401492B RID: 84267
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401492C RID: 84268
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x0401492D RID: 84269
			public static VerifyUnionAction <3>__Verify;

			// Token: 0x0401492E RID: 84270
			public static VerifyUnionAction <4>__Verify;
		}
	}
}
