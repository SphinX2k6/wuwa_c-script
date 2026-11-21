using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739C RID: 29596
	public static class IOpenSplineMoveVerify
	{
		// Token: 0x06033B5A RID: 211802 RVA: 0x006F9208 File Offset: 0x006F7408
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

		// Token: 0x02008666 RID: 34406
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A45 RID: 84549
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014A46 RID: 84550
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
