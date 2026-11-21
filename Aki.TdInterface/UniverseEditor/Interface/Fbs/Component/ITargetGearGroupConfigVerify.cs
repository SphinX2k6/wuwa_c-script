using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200603A RID: 24634
	public static class ITargetGearGroupConfigVerify
	{
		// Token: 0x06029965 RID: 170341 RVA: 0x005AD864 File Offset: 0x005ABA64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITargetGearGroupConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITargetGearGroupConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetGearGroupSuccessConditionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false))
				{
					short offsetId = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITargetGearGroupConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITargetGearGroupConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ICheckGearHitVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 16;
						short valueVOffset2 = 18;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = ITargetGearGroupConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITargetGearGroupConfigVerify.<>O.<2>__Verify = new VerifyUnionAction(TGroupFinishConfigVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020084C2 RID: 33986
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147F5 RID: 83957
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040147F6 RID: 83958
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040147F7 RID: 83959
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
