using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200503B RID: 20539
	public static class IConveyorBeltStateVerify
	{
		// Token: 0x06020E8A RID: 134794 RVA: 0x004935C8 File Offset: 0x004917C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IConveyorBeltStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConveyorBeltStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TConveyorBeltFieldTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConveyorBeltStateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConveyorBeltStateVerify.<>O.<1>__Verify = new VerifyTableAction(IFixSpeedVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007ACC RID: 31436
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134C9 RID: 79049
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040134CA RID: 79050
			public static VerifyTableAction <1>__Verify;
		}
	}
}
