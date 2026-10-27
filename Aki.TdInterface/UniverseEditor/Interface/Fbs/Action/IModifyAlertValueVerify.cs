using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABD RID: 27325
	public static class IModifyAlertValueVerify
	{
		// Token: 0x0602FE3F RID: 196159 RVA: 0x00683BD4 File Offset: 0x00681DD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IModifyAlertValueVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyAlertValueVerify.<>O.<0>__Verify = new VerifyUnionAction(TSetAlertValueTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 12;
					short valueVOffset2 = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IModifyAlertValueVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IModifyAlertValueVerify.<>O.<1>__Verify = new VerifyUnionAction(TAlertValueChangeSpeedVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DAC RID: 32172
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013947 RID: 80199
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013948 RID: 80200
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
