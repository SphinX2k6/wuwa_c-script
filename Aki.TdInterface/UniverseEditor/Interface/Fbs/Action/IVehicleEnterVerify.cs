using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007504 RID: 29956
	public static class IVehicleEnterVerify
	{
		// Token: 0x060367A3 RID: 223139 RVA: 0x00766954 File Offset: 0x00764B54
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

		// Token: 0x02007EBD RID: 32445
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C06 RID: 80902
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013C07 RID: 80903
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
