using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Physics;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D3C RID: 23868
	public static class IPhysicsConstraintComponentVerify
	{
		// Token: 0x06027B2E RID: 162606 RVA: 0x0056E6D8 File Offset: 0x0056C8D8
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

		// Token: 0x02008444 RID: 33860
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014734 RID: 83764
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014735 RID: 83765
			public static VerifyTableAction <1>__Verify;
		}
	}
}
