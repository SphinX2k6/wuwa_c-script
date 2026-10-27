using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2D RID: 23085
	public static class ITargetGearGroupConfigVerify
	{
		// Token: 0x060273ED RID: 160749 RVA: 0x005668A0 File Offset: 0x00564AA0
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

		// Token: 0x02007C53 RID: 31827
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013751 RID: 79697
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013752 RID: 79698
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013753 RID: 79699
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
