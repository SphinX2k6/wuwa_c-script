using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D09 RID: 32009
	public static class IVehicleEnterPathMoveVerify
	{
		// Token: 0x06039C3B RID: 236603 RVA: 0x007CABB0 File Offset: 0x007C8DB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVehicleEnterPathMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleEnterPathMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IVehicleCruisingParamsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IVehicleEnterPathMoveVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVehicleEnterPathMoveVerify.<>O.<1>__Verify = new VerifyUnionAction(TSplineMovePatternVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008758 RID: 34648
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CE2 RID: 85218
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CE3 RID: 85219
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
