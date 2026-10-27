using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007522 RID: 29986
	public static class IVehicleMoveWithPathLineVerify
	{
		// Token: 0x060368C4 RID: 223428 RVA: 0x0076931C File Offset: 0x0076751C
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

		// Token: 0x02007EC3 RID: 32451
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C0E RID: 80910
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013C0F RID: 80911
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
