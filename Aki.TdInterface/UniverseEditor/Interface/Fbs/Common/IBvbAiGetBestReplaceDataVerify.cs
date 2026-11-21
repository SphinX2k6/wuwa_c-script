using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200636D RID: 25453
	public static class IBvbAiGetBestReplaceDataVerify
	{
		// Token: 0x0602B34E RID: 176974 RVA: 0x005E4030 File Offset: 0x005E2230
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiGetBestReplaceDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiGetBestReplaceDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IBvbAiGetBestReplaceDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBvbAiGetBestReplaceDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200850C RID: 34060
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401486E RID: 84078
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
