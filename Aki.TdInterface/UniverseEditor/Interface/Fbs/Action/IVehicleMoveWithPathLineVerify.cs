using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D18 RID: 32024
	public static class IVehicleMoveWithPathLineVerify
	{
		// Token: 0x06039CDA RID: 236762 RVA: 0x007CC5C4 File Offset: 0x007CA7C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVehicleMoveWithPathLineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleMoveWithPathLineVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetVehicleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IVehicleMoveWithPathLineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVehicleMoveWithPathLineVerify.<>O.<1>__Verify = new VerifyUnionAction(TVehicleControlTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200875D RID: 34653
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CE8 RID: 85224
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014CE9 RID: 85225
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
