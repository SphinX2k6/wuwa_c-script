using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200434D RID: 17229
	public static class IPhysicsAngularLimitVerify
	{
		// Token: 0x060198CF RID: 104655 RVA: 0x003A8844 File Offset: 0x003A6A44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPhysicsAngularLimitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhysicsAngularLimitVerify.<>O.<0>__Verify = new VerifyUnionAction(TAngularConstraintMotionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IPhysicsAngularLimitVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IPhysicsAngularLimitVerify.<>O.<0>__Verify = new VerifyUnionAction(TAngularConstraintMotionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short typeIdVOffset3 = 12;
						short valueVOffset3 = 14;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IPhysicsAngularLimitVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IPhysicsAngularLimitVerify.<>O.<0>__Verify = new VerifyUnionAction(TAngularConstraintMotionVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction3, false))
						{
							short offsetId = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IPhysicsAngularLimitVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IPhysicsAngularLimitVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007985 RID: 31109
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013302 RID: 78594
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013303 RID: 78595
			public static VerifyTableAction <1>__Verify;
		}
	}
}
