using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Physics;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005735 RID: 22325
	public static class IPhysicsConstraintComponentVerify
	{
		// Token: 0x0602560E RID: 153102 RVA: 0x0052854C File Offset: 0x0052674C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPhysicsConstraintComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhysicsConstraintComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TPhysicsAttachTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPhysicsConstraintComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPhysicsConstraintComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IPhysicsAngularLimitVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BD6 RID: 31702
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013694 RID: 79508
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013695 RID: 79509
			public static VerifyTableAction <1>__Verify;
		}
	}
}
