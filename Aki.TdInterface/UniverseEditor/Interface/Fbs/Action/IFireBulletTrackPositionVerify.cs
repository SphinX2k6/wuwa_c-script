using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BB RID: 26555
	public static class IFireBulletTrackPositionVerify
	{
		// Token: 0x0602E388 RID: 189320 RVA: 0x0064FE54 File Offset: 0x0064E054
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFireBulletTrackPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFireBulletTrackPositionVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D6D RID: 32109
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F0 RID: 80112
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
