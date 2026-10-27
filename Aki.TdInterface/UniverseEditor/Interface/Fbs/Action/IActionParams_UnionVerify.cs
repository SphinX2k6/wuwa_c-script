using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006088 RID: 24712
	public static class IActionParams_UnionVerify
	{
		// Token: 0x06029F8C RID: 171916 RVA: 0x005C9B60 File Offset: 0x005C7D60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IActionParams_UnionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActionParams_UnionVerify.<>O.<0>__Verify = new VerifyUnionAction(IActionParams_Union_0Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IActionParams_UnionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IActionParams_UnionVerify.<>O.<1>__Verify = new VerifyUnionAction(IActionParams_Union_1Verify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CCB RID: 31947
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137FB RID: 79867
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040137FC RID: 79868
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
