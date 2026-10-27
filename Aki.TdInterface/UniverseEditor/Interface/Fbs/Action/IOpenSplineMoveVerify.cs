using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C35 RID: 27701
	public static class IOpenSplineMoveVerify
	{
		// Token: 0x06030C02 RID: 199682 RVA: 0x0069EDA0 File Offset: 0x0069CFA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenSplineMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenSplineMoveVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 12;
					short valueVOffset2 = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IOpenSplineMoveVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IOpenSplineMoveVerify.<>O.<1>__Verify = new VerifyUnionAction(TSplineMovePatternVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DDC RID: 32220
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013983 RID: 80259
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013984 RID: 80260
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
