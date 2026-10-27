using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007513 RID: 29971
	public static class IVehicleEnterPathMoveVerify
	{
		// Token: 0x06036825 RID: 223269 RVA: 0x00767908 File Offset: 0x00765B08
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

		// Token: 0x02007EBE RID: 32446
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C08 RID: 80904
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013C09 RID: 80905
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
