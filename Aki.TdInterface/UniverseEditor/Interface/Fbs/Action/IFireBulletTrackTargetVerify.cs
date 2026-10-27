using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BE RID: 26558
	public static class IFireBulletTrackTargetVerify
	{
		// Token: 0x0602E3BC RID: 189372 RVA: 0x0065077C File Offset: 0x0064E97C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFireBulletTrackTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFireBulletTrackTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 12;
					short valueVOffset2 = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFireBulletTrackTargetVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFireBulletTrackTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D6E RID: 32110
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F1 RID: 80113
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
