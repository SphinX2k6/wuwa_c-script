using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CFA RID: 31994
	public static class IVehicleEnterVerify
	{
		// Token: 0x06039BB8 RID: 236472 RVA: 0x007C9BA4 File Offset: 0x007C7DA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleEnterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleEnterVerify.<>O.<0>__Verify = new VerifyUnionAction(TVehicleEnteringTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IVehicleEnterVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVehicleEnterVerify.<>O.<1>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 2UL, 2UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008757 RID: 34647
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CE0 RID: 85216
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014CE1 RID: 85217
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
